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
            int COL = 0;
            int MAY = 0;
            int SUM = 0;
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
                    MAT[F, C] = rnd.Next(0, 10);
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
                VEC[C] = SUM;
            }
            MAY = VEC[1];
            COL = 1;
            for (C = 2; C <= N; C++)
            {
                if (VEC[C] > MAY)
                {
                    MAY = VEC[C];
                    COL = C;
                }
            }
            // SALIDA
            for (C = 1; C <= N; C++)
            {
                Console.SetCursorPosition(C * 6, 15);
                Console.Write(VEC[C]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("NÚMERO MAYOR ES {0} ESTA EN LA COLUMNA {1}", MAY, COL);
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}