using System;

namespace CirriVettore3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una app che carica un vettore di 30 elementi con valori casuali compresi tra 0 e 50
              e stampi la media dei valori contenuti nel vettore*/

            Console.WriteLine("Esercizio vettore 3°");

            const int dimensione = 30;
            int[] vettore = new int[dimensione];

            Random generatore = new Random();

            for (int i = 0; i < dimensione; i++)
            {
                vettore[i] = generatore.Next(1, 31);
            }

            int somma = 0;

            for (int i = 0; i < dimensione; i++)
            {
                somma = somma + vettore[i];
            }

            float media = somma / dimensione;

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(vettore[i]);
            }
        }
    }
}
