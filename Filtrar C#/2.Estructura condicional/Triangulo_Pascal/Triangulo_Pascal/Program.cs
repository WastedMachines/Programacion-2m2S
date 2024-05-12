using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 0;
            int C = 0;
            int N = 0;
            string cadena;
            Console.Write("Cuantas Filas: ");
            cadena = Console.ReadLine();
            N = int.Parse(cadena);
            int[,] MAT = new int[N + 1, N + 1];
            // PROCESO
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    if (((C == 1) | (F == C)))
                    {
                        MAT[F, C] = 1;
                    }
                    else
                    {
                        MAT[F, C] = MAT[F - 1, C] + MAT[F - 1, C - 1];
                    }
                }
            }
            // SALIDA
            for (F = 1; F <= N; F++)
            {
            for (C = 1; C <= N; C++)
                {
                    if ((MAT[F, C] != 0))
                    {
                        Console.Write("{0} ", MAT[F, C]);
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}