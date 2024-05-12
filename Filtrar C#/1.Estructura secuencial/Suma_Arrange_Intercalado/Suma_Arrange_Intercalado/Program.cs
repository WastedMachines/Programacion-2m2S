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
            int I = 0;
            int F = 0;
            int[] A = new int[10];
            int[] B = new int[10];
            int[] S = new int[6];
            string linea;
            // INGRESO
            Console.WriteLine("PRIMERO SEGUNDO RESULTADO");
            for (I = 1; I <= 5; I++)
            {
                // ARREGLO 1
                Console.SetCursorPosition(3, I + 2);
                linea = Console.ReadLine();
                A[I] = int.Parse(linea);
                // ARREGLO 2
                Console.SetCursorPosition(10, I + 2);
                linea = Console.ReadLine();
                B[I] = int.Parse(linea);
                // PROCESO
                F = 5;
                // POSICIÓN DE ARREGLO B
                for (I = 1; I <= 5; I++)
                {
                S[I] = A[I] + B[F];
                    F = F - 1;
                }
                // SALIDA
                for (I = 1; I <= 5; I++)
                {
                    Console.SetCursorPosition(18, I + 2);
                    Console.WriteLine(S[I]);
                }
                Console.Write("Pulse una Tecla:");
                Console.ReadLine();
            }
        }
    }
}
