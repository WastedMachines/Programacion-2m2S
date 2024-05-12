using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Thread t = new Thread(metedohilo1);
            t.Start();
            t.Join();
            Thread t2 = new Thread(metedohilo2);
            t2.Start();
            t2.Join();
            Thread t3 = new Thread(metedohilo3);
            t3.Start();
            t3.Join();

        }

        static void metedohilo2()
        {
            Console.WriteLine("Calcular el área triangulo: HILO 2");
            double BASE, ALTURA, RESUL;
            string linea;
            Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
            Console.WriteLine();

        }

        static void metedohilo1()
        {
            Console.WriteLine("MODULO HILO 1");
            Thread.Sleep(1000);
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            Thread.Sleep(1000);
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}",
           DateTime.Now));
            Console.WriteLine();

        }

        static void metedohilo3()
        {
            Console.WriteLine("MODULO HILO 3");
            Thread.Sleep(1000);
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            Thread.Sleep(1000);
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}",
           DateTime.Now));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();

        }


    }

}

