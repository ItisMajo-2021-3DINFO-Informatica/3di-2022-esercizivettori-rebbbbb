using System;

namespace CirriVettore8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrivere un programma che permetta DI MEMORIZZARE i gol fatti di una squadra nelle diverse giornate del campionato 
               (si ipotizzi che il campionato è composto da 8 giornate). 
               Dopo aver inserito i dati, il programma deve visualizzare: 
               - i dati inseriti
               - visualizzare la giornata in cui la squadra ha segnato più gol e il numero dei gol segnati
               - visualizzare la giornata in cui la squadra ha segnato meno gol e il numero dei gol segnati
               - visualizzare la media dei gol segnati per giornata */

            const int dimensione = 8;
            int[] goal = new int[dimensione];

            //ciclo di caricamento del vettore
            for (int i = 0; i < dimensione; i++) // "i" sta per indice
            {
                Console.Write("Goal giornata " + (i + 1) + ": ");
                /*l'elemento del vettore di indice i: gol[i]*/
                goal[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = 0;
            int max = 0;

            //ciclo di visualizzazione del vettore
            for (int i = 0; i < dimensione; i++) // "i" sta per indice
            {
                //goal [0] = 3
                //goal [1] = 5
                Console.WriteLine($"goal[{i}] = {goal[i]}");

                if (goal[i] < min)
                {
                    min = goal[i];
                }

                else if (goal[i] > max)
                {
                    max = goal[i];
                }
            }

            int somma = 0;
            decimal media = 0;

            for (int i = 0; i < dimensione; i++)
            {
                somma = somma + goal[i];
                media = somma / 8;

                Console.WriteLine($"La media è: {media}");
            }
        }
    }
}
