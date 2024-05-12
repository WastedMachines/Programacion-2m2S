using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FACTORES_PRIMOS_DE_UN_NÚMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESI, K;
            string linea;
            Console.Write("NÚMERO: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            K = 2;
            while ((NUM != 1))
            {
                RESI = NUM % K;
                if ((RESI == 0))
                {
                    Console.WriteLine(K);
                    NUM = NUM / K;
                }
                else
                {
                    K = K + 1;
                }
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}