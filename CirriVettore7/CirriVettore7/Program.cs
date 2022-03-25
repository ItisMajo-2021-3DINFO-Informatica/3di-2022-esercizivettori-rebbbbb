using System;

namespace CirriVettore7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un negozio online necessita di un software che menziona il prezzo del proprio catalogo prodotti. Ogni prodotto è identificato
              da un numero progressivo intero a partire da zero, si ipoitizzi che il negozio gestisca 27 prodotti.
              Si scrive un'app console che:
              - sia dotata di una opportuna struttura dati per memorizzare i prezzi dei prodotti
              - consenta il cariamento dei prezzi
              - sia in grado di stampare l'intero catalogo applicando uno sconto del 22%*/

            const int dimensione = 27;
            decimal[] prodotto = new decimal[dimensione];

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine("Inserisci il prezzo: ");
                prodotto[i] = Convert.ToDecimal(Console.ReadLine());
            }

            decimal divisione = 0;
            decimal moltiplicazione = 0;
            decimal sconto = 0;

            for (int i = 0; i < dimensione; i++)
            {
                divisione = prodotto[i] / 100;
                moltiplicazione = divisione * 22;
                sconto = prodotto[i] - moltiplicazione;

                Console.WriteLine($"Il catalogo è {prodotto[i]}");

            }
        }
    }
}
