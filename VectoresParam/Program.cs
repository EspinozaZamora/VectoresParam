﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {

            int[] x = new int[MAX];
            leer(x);
            imprimir(x);
            Console.ReadKey();
        }

        public static void leer( int [] x)
        {
            for( int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\n Ingrese un Elemento {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());

            }
        }
        public static void imprimir(int[] x)
        {
            foreach ( int nume in x)
            {
                Console.WriteLine("\n Elemento {0}", nume);

            }
        }

    }
}
