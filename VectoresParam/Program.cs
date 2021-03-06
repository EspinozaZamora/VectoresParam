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
            if (buscar(x, 15) == true)
                Console.WriteLine("\n15 encontrado");
            else
                Console.WriteLine("\n15 NO EXISTE");
            

            if (buscar2(x, 10) == true)
                Console.WriteLine("\n10 encontrado");
            else
                Console.WriteLine("\n10 NO EXISTE");
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
        public static bool buscar(int []x, int num)
        {
            bool encontrado = false;
            foreach(int numero in x)
            {
                if( numero == num )
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
            
        }
        public static bool buscar2(int[] x, int y)
        {
            bool encontrado = false;
            int i = 0;
            while(i<MAX && encontrado == false)
            {
                if (x[i] == y)
                    encontrado = true;
                i++;

            }
            return encontrado;
        }

    }
}
