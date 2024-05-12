using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }
        static void Main(string[] args)
        {
            string NOM = null;
            string AUX = null;
            string LE = null;
            int POS = 0;
            AUX = "";
            Console.Write("DIGITE UN FRASE:");
            NOM = Console.ReadLine();
            POS = 1;
            while ((POS <= NOM.Length))
            {
                LE = Mid(NOM, POS - 1, 1);
                if ((POS % 2 == 0))
                {
                    AUX = AUX + LE.ToLower();
                }
                else
                {
                    AUX = AUX + LE.ToUpper();
                }
                POS = POS + 1;
            }
        Console.WriteLine("FRASE INTERCALADA :" + AUX);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}