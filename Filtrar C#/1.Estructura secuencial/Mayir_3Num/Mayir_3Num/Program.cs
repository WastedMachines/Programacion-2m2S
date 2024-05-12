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
            int NUM1 = 0;
            int NUM2 = 0;
            int NUM3 = 0;
            string cadena;
            long RESUL = 0;
            Console.Write("DIGITE NÚMERO 1: ");
            cadena = Console.ReadLine();
            NUM1 = int.Parse(cadena);
            Console.Write("DIGITE NÚMERO 2: ");
        cadena = Console.ReadLine();
            NUM2 = int.Parse(cadena);
            Console.Write("DIGITE NÚMERO 3: ");
            cadena = Console.ReadLine();
            NUM3 = int.Parse(cadena);
            RESUL = ob.MAYOR(NUM1, NUM2, NUM3);
            Console.Write("EL MAYOR ES: " + RESUL);
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        private int MAYOR(int N1, int N2, int N3)
        {
            int MAY;
            MAY = N1;
            if (N2 > MAY)
            {
                MAY = N2;
            }
            if (N3 > MAY)
            {
                MAY = N3;
            }
            return MAY;
        }
    }
}
