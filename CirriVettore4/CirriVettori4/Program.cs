using System;

namespace CirriVettori4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crea una app che carica un vettore di 100 elementi con valori casuali compresi tra 1000 e 3000
               e stampi il più grande ed il più piccolo dei valori contenuti nel vettore */


            Console.WriteLine("Esercizio vettori 4°");

            const int dimensione = 100;
            int[] vettore = new int[dimensione];

            Random generatore = new Random();

            for (int i = 0; i < dimensione; i++)
            {
                vettore[i] = generatore.Next(1000, 3001);

                if ()
            }

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(vettore[i]);
            }
        }
    }
}
