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
            double SUMT = 0;
            double SUE = 0;
            double PROM = 0;
            int CAN = 0;
            string linea;
            SUMT = 0;
            do
            {
                Console.Write("DIGITE SUELDO:");
                linea = Console.ReadLine();
                SUE = double.Parse(linea);
                if (SUE > 0)
                {
                    SUMT = SUMT + SUE;
                    CAN = CAN + 1;
                }
            } while (SUE > 0);
            PROM = SUMT / CAN;
            Console.WriteLine();
            Console.WriteLine("TOTAL SUELDOS: " + SUMT);
            Console.WriteLine("EMPLEADOS : " + CAN);
            Console.WriteLine("PROMEDIO : " + PROM);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}