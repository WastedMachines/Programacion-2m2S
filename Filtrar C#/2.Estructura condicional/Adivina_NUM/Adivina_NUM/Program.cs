using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
namespace JUEGO_ADIVINA_UN_NÚMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            const int OPOR = 4;
            int NUM, ADI;
            byte I, SW;
            string linea;
            //GENERO EL NÚMERO ENTRE 1 AL 20;
        Random ran = new Random();
            do
            {
                NUM = Convert.ToInt32(ran.Next(100));
            } while (!(((NUM >= 1) & (NUM <= 20))));
            //PROCESO;
            I = 1; SW = 0;
            do
            {
                Console.Write("PIENSA QUÉ NÚMERO SERÁ:"); linea = Console.ReadLine();
                ADI = int.Parse(linea);
                if ((ADI == NUM))
                {
                    Console.WriteLine("ADIVINASTE ERES GENIAL");
                    SW = 1;
                }
                else
                {

                    if ((ADI > NUM))
                    {
                        Console.WriteLine("TE PASASTE");

                    }

                    else
                    {
                        Console.WriteLine("ESTÁS BAJO");

                    }
                }
                I++;
            } while (((I <= OPOR) & (SW == 0)));
            if ((SW == 0))
            {
                Console.Write("EL NÚMERO FUE: " + NUM);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}