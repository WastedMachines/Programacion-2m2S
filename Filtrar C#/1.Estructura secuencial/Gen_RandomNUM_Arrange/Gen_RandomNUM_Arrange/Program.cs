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
            int CAN = 0;
            int POS = 0;
            string linea;
            Random rnd = new Random();
            Console.Write("CUANTOS ALEATORIOS:");
            linea = Console.ReadLine();
            CAN = int.Parse(linea);
            double[] VEC = new double[CAN + 1];
            byte[] VEC1 = new byte[CAN + 1];
            // GENERACIÓN DE ALEATORIOS
            for (POS = 1; POS <= CAN; POS++)
            {
                VEC[POS] = rnd.Next(0, 99);
                // OBTENEMOS UN ENTERO DE 2 CIFRAS
            }
            // SALIDA DEL ARREGLO
            for (POS = 1; POS <= CAN; POS++)
            {
                Console.SetCursorPosition(3, POS + 2);
                Console.WriteLine(VEC[POS]);
                Console.SetCursorPosition(30, POS + 2);
                Console.WriteLine(VEC1[POS]);
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}