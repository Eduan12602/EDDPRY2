using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_recursividad
{
    public static class Exponente
    {
        public static int Run(int @base, int exponent)
        {
            if (exponent == 0) return 1; // Caso base
            return @base * Run(@base, exponent - 1); // Recursión
        }
    }
    }

    
