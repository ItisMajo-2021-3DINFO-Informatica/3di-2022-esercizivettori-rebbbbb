using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirriVettore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*aggiungi il codice per caricare un vettore di 567 elementi con valori interi casuali compresi tra -100 e 100*/

            Console.WriteLine("Esercizio vettori");

            const int dimensione = 567;
            int[] vettore = new int[dimensione];

            Random generatore = new Random();

            for (int i = 0; i < dimensione; i++)
            {
                vettore[i] = generatore.Next(-100, 101);
            }

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(vettore[i]);
            }

            Console.ReadLine();


            /*ROBA VETTORI
              1. visualizzazione di dati in un vettore
              2. visualizzazione di un vettore
              3. ricerca del valore massimo in un vettore
              4. ricerca dell'indice del valore massimo
              5. ricerca del valore minimo in un vettore
              6. ricerca dell'indice del valore minimo
              7. calcolo della media
                7a. calcolo della somma degli elementi di un vettore
                7b. conteggio degli elementi del vettore in base ad un criterio
                7c. il tipo della media è float/doube/decimal --> casting del valore della variabile somma. Trasformo il valore della variabile somma da int a float.
                    Ci serve perchè altrimenti il risultato della divisione tra un int e un altro numero dà come risultato un intero,
                    mentre la media poterebbe essere un numero decimale [esempio --> media = (float)somma/conta;]*/
        }
    }
}
