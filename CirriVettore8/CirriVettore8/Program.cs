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
               - visualizzare la media dei gol segnati per giornata 
               - goal subiti */

            const int dimensione = 8;
            int[] goal = new int[dimensione];
            int[] goalSubiti = new int[dimensione];
            int max;
            int posMax;
            int min;
            int posMin;
            int somma;
            float media;

            //ciclo di caricamento da tastiera del vettore
            for (int i = 0; i < dimensione; i++) // "i" sta per indice
            {
                Console.Write("Goal giornata " + (i + 1) + ": ");  // l'elemento del vettore di indice i: goal[i]
                goal[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < dimensione; i++) 
            {
                Console.Write("Goal subiti giornata " + (i + 1) + ": ");
                goalSubiti[i] = Convert.ToInt32(Console.ReadLine());
            }

            //ciclo di visualizzazione del vettore
            for (int i = 0; i < dimensione; i++) // "i" sta per indice
            {
                Console.WriteLine($"goal[{i}] = {goal[i]}"); //goal [0] = 3 [...]
            }

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine($"goal subiti[{i}] = {goalSubiti[i]}");
            }

            //ricerca del massimo e della sua posizione
            max = goal[0];
            posMax = 0;

            for (int i = 1; i < dimensione; i++)
            {
                if (goal[i] > max)
                {
                    max = goal[i];
                    posMax = i;
                }
            }

            //ricerca del minimo e della sua posizione
            min = goal[0];
            posMin = 0;

            for (int i = 1; i < dimensione; i++)
            {
                if (goal[i] < min)
                {
                    min = goal[i];
                    posMin = i;
                }
            }

            //media

            for (int i = 1; i < dimensione; i++)
            {
                somma = somma + goal[i];
            }

            media = (float)somma / 8;

            //stampa

            Console.WriteLine($"il valore massimo è {max} nella giornata {posMax + 1}");
            Console.WriteLine($"il valore massimo è {min} nella giornata {posMin + 1}");
            Console.WriteLine($"La media dei goal è {media}");

            
            Console.WriteLine("Batti un tasto per terminare");
            Console.ReadKey();
        }
    }
}
