using System;

namespace CirriVettore6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 80 giocatori di golf hanno giocato in squadra un incontro a 18 buche i risultati vengono letti sequenzialmente;
               occorre utilizzare l'opportuna struttura dati per memorizzare il numero di colpi complesso di ciascun giocatore
               e stabilire chi è il giocatore migliore */

            const int dimensione = 80;
            int[] colpi = new int[dimensione];

            for(int i = 0; i < dimensione; i++)
            {
                colpi[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = int.MaxValue;
            int giocatoreMigliore = 0;

            for (int i = 0; i < dimensione; i++)
            {
                if (colpi [i] < min)
                {
                    min = colpi[i];
                    giocatoreMigliore = i;
                }
            }

            Console.WriteLine($"Il giocatore migliore è il numero: {giocatoreMigliore}");
        }
    }
}
