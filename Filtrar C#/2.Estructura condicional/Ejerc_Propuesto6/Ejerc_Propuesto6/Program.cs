using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
namespace Ejercicio_Propuesto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RES, TOT = 0;
            string linea;
            do
            {
                Console.Write("INGRESE UN NUMERO :");
                linea = Console.ReadLine();
                NUM = int.Parse(linea);
                RES = NUM % 2;
                if (RES == 0 && NUM != 0)
                    TOT = TOT + NUM;
                else
                {
                }
            } while (RES == 0 && NUM != 0);

            Console.WriteLine("La suma total es: " + TOT);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();

        }
    }
}
