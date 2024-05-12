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
            int K = 0;
            int CAN = 0;
            int RESUL = 0;
            string cadena;
            Program ob = new Program();
            // INGRESO
            Console.Write("CUANTOS ELEMENTOS: ");
            cadena = Console.ReadLine();
            CAN = int.Parse(cadena);
            int[] VEC = new int[CAN + 1];
            Random rnd = new Random();
            for (K = 1; K <= CAN; K++)
            {
                VEC[K] = rnd.Next(1, 100);
                Console.Write(VEC[K] + ", ");
            }
            Console.WriteLine();
            RESUL = ob.VECTORMENOR(VEC, CAN);
            Console.WriteLine();
            Console.WriteLine("EL MENOR ES ES: " + RESUL);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        private int VECTORMENOR(int[] NUEVO, int N)
        {
        int MEN = 0;
            int I = 0;
            MEN = NUEVO[1];
            for (I = 2; I <= N; I++)
            {
                if ((NUEVO[I] < MEN))
                    MEN = NUEVO[I];
            }
            return MEN;
        }
    }
}