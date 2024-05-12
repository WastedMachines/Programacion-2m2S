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
            string RESUL = null
           ;
            string cadena;
            Program ob = new Program();
            Console.Write("DIGITE NÚMERO : ");
            cadena = Console.ReadLine();
            NUM = int.Parse(cadena);
            RESUL = ob.DIASEMANA(NUM);
            Console.WriteLine();
            Console.WriteLine("RESULTADO ES: " + RESUL);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();

        }
        private string DIASEMANA(int DIA)

        {
            string R = null
           ;
            switch (DIA)

            {
                case 1:
                    R = "DOMINGO"
                   ;
                    break
                    ;
                case 2:
                    R = "LUNES"
                   ;
                    break
                   ;
                case 3:
                    R = "MARTES"
                   ;
                    break
                    ;
                case 4:
                    R = "MIÉRCOLES"
                   ;
                    break
                    ;
                case 5:
                    R = "JUEVES"
                   ;
                    break
                    ;
                case 6:
                    R = "VIERNES"
                   ;
                    break
                    ;
                case 7:
                    R = "SÁBADO"
                   ;
                    break
                    ;
                default
           :
                    R = "FUERA DE RANGO"
                   ;
                    break
                   ;

            }
            return (R);

        }

    }
}
