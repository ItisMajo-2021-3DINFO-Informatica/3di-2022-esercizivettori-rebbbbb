using System;

namespace CirriVettore2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crea una app che carica un vettore di 100 elementi con valori casuali compresi tra 1 e 100
            e stampi il numero di valori contenuti nel vettore che risultano superiori a 50 */

            Console.WriteLine("Esercizio vettori 2°");

            const int dimensione = 100;
            int[] vettore = new int[dimensione];

            Random generatore = new Random();

            for (int i = 0; i < dimensione; i++)
            {
                vettore[i] = generatore.Next(1, 101);

                if (dimensione > 50)
                {
                    
                }
            }

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(vettore[i]);
            }
        }
    }
}
