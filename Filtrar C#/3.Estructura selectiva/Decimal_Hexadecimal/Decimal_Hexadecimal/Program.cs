﻿using System;
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
            const int BASE = 16;
            int NUM = 0;
            int AUX = 0;
            int POS = 0;
            int I = 0;
            string[] VEC = new string[21];
            string DAT;
            string linea;
            Console.Write("DIGITE UN NÚMERO:");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            // PROCESO
            POS = 1;
            while ((NUM >= BASE))
            {
                AUX = NUM % BASE;
                switch (AUX)
                {
                    case 10:
                        DAT = "A";
                        break;
                    case 11:
                        DAT = "B"
    ;
                        break
                        ;
                    case 12:
                        DAT = "C"
                       ;
                        break
                        ;
                    case 13:
                        DAT = "D"
                       ;
                        break
                        ;
                    case 14:
                        DAT = "E"
                       ;
                        break
                        ;
                    case 15:
                        DAT = "F"
                       ;
                        break
                        ;
                    default
               :
                        DAT = AUX.ToString();
                        break
                        ;

                }
                VEC[POS] = DAT;
                POS = POS + 1;
                NUM = NUM / BASE;

            }
            // FIN DEL WHILE
            switch (NUM)

            {
                case 10:
                    DAT = "A"
                   ;
                    break
                    ;
                case 11:
                    DAT = "B"
                   ;
                    break
                    ;
                case 12:
                    DAT = "C"
                   ;
                    break
                    ;
                case 13:
                    DAT = "D"
                   ;
                    break
                    ;
                case 14:
                    DAT = "E"
                   ;
                    break
                    ;
                case 15:
                    DAT = "F"
                   ;
                    break
                    ;
                default
           :
                    DAT = Convert.ToString(NUM);
                    break
                    ;

            }
            VEC[POS] = DAT;
            // SALIDA
            for (I = POS; I >= 1; I +=
           -1)

            {
                Console.Write(VEC[I] + " ");

            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();

        }

    }
}