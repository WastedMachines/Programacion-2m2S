using System;
public class Ejemplo36
{
    public static void Main()
    {
        int[] numero = new int[5]; /* Un array de 5 números enteros */
        int suma; /* Un entero que será la suma */
        int i; /* Para recorrer los elementos */
        for (i = 0; i <= 4; i++) /* Pedimos los datos */
        {
            Console.Write("Introduce el dato numero {0}: ", i + 1);
            numero[i] = Convert.ToInt32(Console.ReadLine());
        }
        suma = 0; /* Valor inicial de la suma */
        for (i = 0; i <= 4; i++) /* Y hallamos la suma repetitiva */
        {
            suma += numero[i];
            Console.WriteLine("Su suma es {0}", suma);
        }
        Console.ReadKey();
    }
}