﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class SimbolosEspeciales
    {
        public static char Epsilon = (char)5;
        public static char FIN = (char)0;
        public static int ERROR = 20000;
        public static int OMITIR = 20001; // Se pone en los tokens que se quieran omitir
    }
}
