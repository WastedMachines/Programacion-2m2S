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
            int NUM1 = 0;
            int NUM2 = 0;
            string RESUL;
            string cadena;
            Program ob = new Program();
            Console.Write("DIGITE NÚMERO 1: ");
            cadena = Console.ReadLine();
            NUM1 = int.Parse(cadena);
            Console.Write("DIGITE NÚMERO 2: ");
            cadena = Console.ReadLine();
            NUM2 = int.Parse(cadena);
            RESUL = ob.MULTIPLO(NUM1, NUM2);
            Console.WriteLine();
            Console.WriteLine("{0} {1} DE {2}", NUM1, RESUL, NUM2);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        private string MULTIPLO(int N1, int N2)
        {
            string R;
            int num;
            num = N1 % N2;
        if (num == 0)
            {
                R = "ES MÚLTIPLO";
            }
            else
            {
                R = "NO ES MÚLTIPLO";
            }
            return R;
        }
    }
}
