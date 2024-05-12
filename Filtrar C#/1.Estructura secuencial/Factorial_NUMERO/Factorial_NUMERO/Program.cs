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
            Program ob = new Program();
            int NUM = 0;
            long RESUL = 0;
            string cadena;
            Console.Write("DIGITE UN NÚMERO: ");
            cadena = Console.ReadLine();
            NUM = int.Parse(cadena);
            RESUL = ob.FACTORIAL(NUM);
            Console.Write("EL FACTORIAL DE {0} ES: {1} ", NUM, RESUL);
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
        Console.ReadLine();
        }
        private long FACTORIAL(int AUX)
        {
            long RES = 1;
            byte K = 0;
            for (K = 2; K <= AUX; K++)
            {
                RES = RES * K;
            }
            return RES;
        }
    }
}