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
            int CAN = 0;
            int SUMP = 0;
            int SUMI = 0;
            int[] VEC = new int[13];
            string linea;
            Console.Write("CUANTOS ELEMENTOS MÁX=12:");
            linea = Console.ReadLine();
            CAN = int.Parse(linea);
            // INGRESO
            for (I = 1; I <= CAN; I++)
            {
                Console.Write("POSICIÓN {0} ==>", I);
                linea = Console.ReadLine();
                VEC[I] = int.Parse(linea);
            }
            // PROCESO
            SUMP = 0;
            SUMI = 0;
            for (I = 1; I <= CAN; I++)
            {
                if ((VEC[I] % 2) == 0)
                {
                    SUMP = SUMP + VEC[I];
                }
                else
                {
                    SUMI = SUMI + VEC[I];
                }
            }
            // SALIDA
            Console.WriteLine();
            Console.WriteLine("SUMA VALORES PARES: " + SUMP);
            Console.WriteLine("SUMA VALORES IMPARES: " + SUMI);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}