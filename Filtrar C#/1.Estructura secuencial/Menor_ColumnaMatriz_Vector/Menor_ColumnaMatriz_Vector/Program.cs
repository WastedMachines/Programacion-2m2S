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
            int MEN = 0;
            string cadena;
            // INGRESO
            // PARA COMODIDAD GENERAMOS VALORES PARA LA MATRIZ
            Console.Write("TAMAÑO DE LA MATRIZ: ");
            cadena = Console.ReadLine();
            N = int.Parse(cadena);
            int[,] MAT = new int[100, 100];
            int[] VEC = new int[N + 1];
            Random rnd = new Random();
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 100);
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            // PROCESO
            for (C = 1; C <= N; C++)
            {
                MEN = MAT[1, C];
                for (F = 1; F <= N; F++)
                {
                    if ((MAT[F, C] < MEN))
                        MEN = MAT[F, C];
                }
                VEC[C] = MEN;
            }
            // SALIDA
            for (C = 1; C <= N; C++)
            {
                Console.SetCursorPosition(C * 4, 15);
                Console.Write(VEC[C]);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}