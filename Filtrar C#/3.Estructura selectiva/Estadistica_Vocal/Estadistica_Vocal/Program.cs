﻿using System;
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
            string NOM;
            int K = 0;
            int A = 0;
            int E = 0;
            int I = 0;
            int O = 0;
            int U = 0;
            string LE;
            Console.Write("DIGITE UNA FRASE : ");
            NOM = Console.ReadLine();
            A = 0;
            E = 0;
            I = 0;
            O = 0;
            U = 0;
            for (K = 1; K < NOM.Length; K++)
            {
                NOM = NOM.ToUpper();
                LE = Mid(NOM, K, 1);
                switch (LE)
                {
                    case "A":
                        A = A + 1;
                        break;
                    case "E":
                        E = E + 1;
                        break;
                    case "I":
                        I = I + 1;
                        break;
                    case "O":
                        O = O + 1;
                        break;
                    case "U":
                        U = U + 1;
                        break;
                }
            }
            Console.WriteLine("EXISTEN {0} VOCALES A", A);
            Console.WriteLine("EXISTEN {0} VOCALES E", E);
            Console.WriteLine("EXISTEN {0} VOCALES I", I);
            Console.WriteLine("EXISTEN {0} VOCALES O", O);
            Console.WriteLine("EXISTEN {0} VOCALES U", U);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}