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
            char ECIVIL;
            string linea;
            Console.Write("DIGITE C,S,V,D :"); linea = Console.ReadLine();
            ECIVIL = char.Parse(linea);
            switch (ECIVIL)
            {
                case 'C':
                    ; Console.WriteLine("CASADO");
                    break;
                case 'S':
                    ; Console.WriteLine("SOLTERO");
                   
            break;
                case 'V':
                    ; Console.WriteLine("VIUDO");
                    break;
                case 'D':
                    ; Console.WriteLine("DIVORCIADO");
                    break;
                default:
                    Console.WriteLine("NO EXISTE");
                    break;
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}

