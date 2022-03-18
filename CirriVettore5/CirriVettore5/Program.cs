using System;

namespace CirriVettore5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una app che carica un vettore di 1000 elementi con valori casuali compresi tra 1 e 250
              e stampi quanti elementi in percentuale sono minori di 175*/

            Console.WriteLine("Esercizio vettori 5°");

            const int dimensione = 1000;
            int[] vettore = new int[dimensione];
            int percentuale = Convert.ToInt32(Console.ReadLine());

            Random generatore = new Random();

            for (int i = 0; i < dimensione; i++)
            {
                vettore[i] = generatore.Next(1, 251);
            }

            for (int i = 0; i > dimensione; i++)
            {
                percentuale = vettore[i] / 100;

                if (percentuale < 175)
                {
                    Console.WriteLine("Il numero è minore di 175");
                }
            }

            /* for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(vettore[i]);
            } */
        }
    }
}
