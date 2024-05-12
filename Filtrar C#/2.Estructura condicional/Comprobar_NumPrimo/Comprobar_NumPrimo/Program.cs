using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
namespace Comprobar_si_es_Numero_Primo
{
    class Program
    {

    static void Main(string[] args)
        {
            int n, x, sw, resi;
            string linea;
            x = 2;
            sw = 0;
            Console.WriteLine("NUMERO PRIMO");
            Console.WriteLine();
            Console.Write("Ingrese el numero:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x < n && sw == 0)
            {
                resi = n % x;
                if (resi == 0)
                {
                    sw = 1;
                }
                else
                {
                    x = x + 1;
                }
            }
            if (sw == 0)
            {
                Console.WriteLine();
                Console.WriteLine("El numero es PRIMO");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El numero no es PRIMO");
            }
            Console.ReadKey();
        }
    }
}