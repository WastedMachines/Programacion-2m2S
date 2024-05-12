using System;
using System.Collections.Generic;
using System.Linq;
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
            RESUL = ob.MIABS(NUM);
            Console.Write("VALOR ABSOLUTO ES: " + RESUL);
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        private long MIABS(int AUX)
        {
            if (AUX < 0)
            {
                AUX = AUX * -1;
            }
            return AUX;
        }
    }
}