using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class AnalizLexico
    {
        int token, EdoActual, EdoTransicion;
        string CadenaSigma;
        public string Lexema;
        bool PasoPorEdoAcept;
        int IniLexema, FinLexema, IndiceCaracterActual;
        char CaracterActual;
        Stack<int> Pila = new Stack<int>();
        public AFD AutomataFD;

        public AnalizLexico()
        {
            CadenaSigma = "";
            PasoPorEdoAcept = false;
            IniLexema = FinLexema = -1;
            IndiceCaracterActual = -1;
            token = -1;
            Pila.Clear();
            AutomataFD = null;
        }

        public AnalizLexico(string sigma, string FileAFD, int IdAFD)
        {
            AutomataFD = new AFD();
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();

            AutomataFD.LeerAFDdeArchivo(FileAFD, IdAFD);
        }

        public AnalizLexico(string sigma, string FileAFD)
        {
            AutomataFD = new AFD();
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            AutomataFD.LeerAFDdeArchivo(FileAFD, -1);
        }

        public AnalizLexico(string FileAFD, int IdAFD)
        {
            AutomataFD = new AFD();
            CadenaSigma = "";
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(FileAFD, IdAFD);
        }

        public AnalizLexico(string sigma, AFD AutFD)
        {
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();
            AutomataFD = AutFD;
        }
        /*guarda la informacion de las variables para saber el estado del analizador en x momento
         Lo que retorna son puras variables o informacion*/
        public ClassEstadoAnalizLexico GetEdoAnalizLexico()
        {
            ClassEstadoAnalizLexico EdoActualAnaliz = new ClassEstadoAnalizLexico();
            EdoActualAnaliz.CaracterActual = CaracterActual;
            EdoActualAnaliz.EdoActual = EdoActual;
            EdoActualAnaliz.EdoTransicion = EdoTransicion;
            EdoActualAnaliz.FinLexema = FinLexema;
            EdoActualAnaliz.IndiceCaracterActual = IndiceCaracterActual;
            EdoActualAnaliz.IniLexema = IniLexema;
            EdoActualAnaliz.Lexema = Lexema;
            EdoActualAnaliz.PasoPorEdoAcept = PasoPorEdoAcept;
            EdoActualAnaliz.token = token;
            EdoActualAnaliz.Pila = Pila;
            return EdoActualAnaliz;
        }

        /*para darle un estado en especifico al estado del analizador lexico*/
        public bool SetEdoAnalizLexico(ClassEstadoAnalizLexico e)
        {
            CaracterActual = e.CaracterActual;
            EdoActual = e.EdoActual;
            EdoTransicion = e.FinLexema;
            IndiceCaracterActual = e.IndiceCaracterActual;
            IniLexema = e.IniLexema;
            Lexema = e.Lexema;
            PasoPorEdoAcept = e.PasoPorEdoAcept;
            token = e.token;
            Pila = e.Pila;
            return true;
        }

        /*se puede cambiar la cadena sigma a ser analizada*/
        public void SetSigma(string sigma)
        {
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();
        }

        /*sellamara cada vez que se requiera un token. El metodo regresa el valor entero 
         que corresponde al token que se esta obteniendo*/
        public int yylex()
        {
            while (true)
            {
                /*se guarda en la pila para poder regresar si se requiere*/
                Pila.Push(IndiceCaracterActual);
                if (IndiceCaracterActual >= CadenaSigma.Length)
                {
                    Lexema = "";
                    /*si ya terminó regreso 0*/
                    return SimbolosEspeciales.FIN;
                }
                IniLexema = IndiceCaracterActual;
                EdoActual = 0;
                PasoPorEdoAcept = false;
                FinLexema = -1;
                token = -1;
                while (IndiceCaracterActual < CadenaSigma.Length)
                {
                    CaracterActual = CadenaSigma[IndiceCaracterActual];
                    EdoTransicion = AutomataFD.TablaAFD[EdoActual, CaracterActual];
                    if (EdoTransicion != -1)
                    {
                        if (AutomataFD.TablaAFD[EdoTransicion, 256] != -1)//va a la ultima columna para ver si el token es -1
                            //si es diferente de -1 es el fin de lexema
                        {
                            PasoPorEdoAcept = true;
                            token = AutomataFD.TablaAFD[EdoTransicion, 256];
                            FinLexema = IndiceCaracterActual;
                        }
                        IndiceCaracterActual++;
                        EdoActual = EdoTransicion;
                        continue;
                    }
                    break;
                }//no hay transicion del estado actual con el caracter actual

                if (!PasoPorEdoAcept)
                {
                    IndiceCaracterActual = IniLexema + 1;
                    Lexema = CadenaSigma.Substring(IniLexema, 1);
                    token = 20000;//SIMBOLOSESPECIALES.ERROR
                    return token;
                }
                //No hay transicion con el caracter actual, pero ya se había pasado por edo de aceptación
                Lexema = CadenaSigma.Substring(IniLexema, FinLexema - IniLexema + 1);
                IndiceCaracterActual = FinLexema + 1;

                if (token == SimbolosEspeciales.OMITIR)
                    continue;
                else
                    return token;
            }
        }
        /*regresa un lexeme identificado por el yylex y la cadena de entrada*/
        public bool UndoToken()
        {
            if (Pila.Count == 0)
                return false;

            IndiceCaracterActual = Pila.Pop();
            return true;
        }
    }
}
