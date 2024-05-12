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
            string RESUL = null;
            string cadena;
            Program ob = new Program();
            Console.Write("DIGITE NÚMERO : ");
            cadena = Console.ReadLine();
            NUM1 = int.Parse(cadena);
            RESUL = ob.BINARIO(NUM1);
            Console.WriteLine();
            Console.WriteLine("RESULTADO ES: " + RESUL);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        private string BINARIO(int NUM)
        {
            int K = 0;
            int AUX = 0;
            string R = null;
            string BIN = null;
            R = "";
            while ((NUM >= 2))
            {
                AUX = NUM % 2;
                R = R + AUX.ToString();
                NUM = NUM / 2;
            }
            R = R + NUM.ToString();
            BIN = "";
            for (K = R.Length; K >= 1; K += -1)
            {
                BIN = BIN + R.Substring(K - 1, 1);
            }
            return BIN;
        }
    }
}
