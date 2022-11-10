using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class Transicion
    {
        private char SInf;
        private char Sdup;
        private Estado edo;

        public Transicion(char simb, Estado e)
        {
            SInf = simb;
            Sdup = simb;
            edo = e;
        }

        public Transicion(char simb1, char simb2, Estado e)
        {
            SInf = simb1;
            Sdup = simb2;
            edo = e;
        }

        /*Permite inicializar una transicion aunque no haya estados o simbolos*/
        public Transicion()
        {
            edo = null;
        }

        /*Seccion de settransicion similares al constructor*/
        public void SetTransicion(char simb, Estado e)
        {
            SInf = simb;
            Sdup = simb;
            edo = e;
        }

        public void SetTransicion(char simb1, char simb2, Estado e)
        {
            SInf = simb1;
            Sdup = simb2;
            edo = e;
        }

        /*GET and SET para los simbolos superiores e inferiores*/
        public char SimInf { get => SInf; set => SInf = value; }
        public char SimSup { get => Sdup; set => Sdup = value; }

        /*Pregunta si existe el caracter en el rango de la transicion, 
         * si existe retorna el estado hacía el que va, 
         * sino retorna null*/
        public Estado GetEdoTrans(char s)
        {
            if(SInf <= s && s <= Sdup)
            {
                return edo;
            }
            return null;
        }
    }
}
