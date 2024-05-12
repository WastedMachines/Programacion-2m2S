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
            int SUM = 0;
            string cadena;
        // INGRESO
        // PARA COMODIDAD GENERAMOS VALORES PARA LA MATRIZ
 Console.Write("TAMAÑO DE LA MATRIZ: ");
            cadena = Console.ReadLine();
            N = int.Parse(cadena);
            int[,] MAT = new int[N + 1, N + 1];
            double[] VEC = new double[N + 1];
            Random rnd = new Random();
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = rnd.Next(0, 100);
                    Console.SetCursorPosition(C * 6, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            // PROCESO
            for (C = 1; C <= N; C++)
            {
                SUM = 0;
                for (F = 1; F <= N; F++)
                {
                    SUM = SUM + MAT[F, C];
                }
                VEC[C] = SUM / N;
            }
            // SALIDA
            for (C = 1; C <= N; C++)
            {
                Console.SetCursorPosition(C * 6, 15);
                Console.Write(string.Format("{0:##.0}", VEC[C]));
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}