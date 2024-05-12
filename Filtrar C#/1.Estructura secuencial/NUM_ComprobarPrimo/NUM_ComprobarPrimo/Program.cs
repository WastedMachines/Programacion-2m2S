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
            int NUM = 0;
            string RESUL = null;
            string cadena;
            Program ob = new Program();
            Console.Write("DIGITE NÚMERO : ");
            cadena = Console.ReadLine();
            NUM = int.Parse(cadena);
            RESUL = ob.PRIMO(NUM);
            Console.WriteLine();
            Console.WriteLine("RESULTADO ES: " + RESUL);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    private string PRIMO(int N)
        {
            int K = 0;
            int SW = 0;
            int RESI = 0;
            K = 2;
            SW = 0;
            while (((K < N) & (SW == 0)))
            {
                RESI = N % K;
                if ((RESI == 0))
                {
                    SW = 1;
                }
                else
                {
                    K = K + 1;
                }
            }
            if ((SW == 0))
            {
                return "PRIMO";
            }
            else
            {
                return "NO PRIMO";
            }
        }
    }
}