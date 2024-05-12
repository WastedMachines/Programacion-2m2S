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
            int I = 0;
            int CAN = 0;
            int J = 0;
            int ALTO = 0;
            int BAJO = 0;
            int CENTRAL = 0;
            int BUS = 0;
            int AUX = 0;
            string linea;
            Random rnd = new Random();
            Console.Write("CUANTOS ELEMENTOS:");
            linea = Console.ReadLine();
            CAN = int.Parse(linea);
            int[] VEC = new int[CAN + 1];
            bool ENCONTRADO = false;
            // INGRESO
            for (I = 1; I <= CAN; I++)
            {
                VEC[I] = rnd.Next(0, 99);
            }
            // SALIDA DEL ARREGLO ALEATORIO
            for (I = 1; I <= CAN; I++)
            {
            Console.SetCursorPosition(3, I + 2);
                Console.WriteLine(VEC[I]);
            }
            // PRIMERO ORDENAMOS EL ARREGLO
            for (J = 1; J <= CAN; J++)
            {
                for (I = 1; I <= CAN - 1; I++)
                {
                    if ((VEC[I] > VEC[I + 1]))
                    {
                        AUX = VEC[I];
                        VEC[I] = VEC[I + 1];
                        VEC[I + 1] = AUX;
                    }
                }
            }
            // SALIDA DEL ARREGLO ORDENADO
            for (I = 1; I <= CAN; I++)
            {
                Console.SetCursorPosition(10, I + 2);
                Console.WriteLine(VEC[I]);
            }
            // AHORA SI LA BÚSQUEDA
            Console.Write("ELEMENTO A BUSCAR:");
            linea = Console.ReadLine();
            BUS = int.Parse(linea);
            BAJO = 1;
            ALTO = CAN;
            // CENTRAL = (BAJO + ALTO) / 2
            while (((BAJO <= ALTO) & (ENCONTRADO == false)))
            {
                CENTRAL = (BAJO + ALTO) / 2;
                if ((VEC[CENTRAL] == BUS))
                {
                    ENCONTRADO = true;
                }
                else
                {
                    if ((VEC[CENTRAL] > BUS))
                    {
                        ALTO = CENTRAL - 1;
                    }
                    else
                    {
                        BAJO = CENTRAL + 1;
                    }
                }
            }
            if ((ENCONTRADO))
            {
                Console.WriteLine("{0} Encontrado en la posicion {1}", BUS, CENTRAL);
            }
            else
            {
                Console.WriteLine("No existe {0} ", BUS);
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}