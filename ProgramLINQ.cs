using System;
using NExLinq;
using System.Collections.Generic;
using System.Linq;


namespace NProgramLINQ
{
    class ProgramLINQ
    {
        public static void TestLINQ()
        {

            Console.WriteLine("LINQ");

            // utilizzo IEnumerable
            IEnumerable<string> myIE = Enumerable.Empty<string>();
            myIE = LinqUtils.GetCity("Arezzo");
            Console.WriteLine(myIE.First());
            //---------------------------------------


            // Utilizzo la LIST
            Console.WriteLine(LinqUtils.GetCityList("Arezzo").Count);
            Console.WriteLine(LinqUtils.GetCityList("Arezzo")[0]);

        }

        public static void WorkLinq2()  // Working with LINQ pt2 (#8)
        {
            //   Ogni vetta ha un nome, un'altezza ed una posizione geografica. Questi campi sono separati da una virgola.
            // L'ordine dei campi è garantito, troverai sempre nome vetta, altezza e posizione geografica.Una vetta è inoltre separata dall'altra con un punto e virgola. 
            // Devi trasformare la stringa passando attraverso vari step, elencati di seguito.
            //	[ ] Il tuo primo compito è quello di creare una lista di vette a partire dalla stringa separandola in corrispondenza del punto e virgola
            //•	[ ] Le stringhe che hai ottenuto potrebbero avere spazi non desiderati all'inizio ed alla fine della stringa. Eliminali
            //•	[ ] Infine estrai solo la stringa "Monte Nome" dalla struttura ottenuta in precedenza

            //Crere funzione di ricerca LINQ

            const string stringaIniziale = "Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano";

            // CONVERSIONE stringa in List 

            List<string> ListVette = stringaIniziale.Split(';').ToList();  //Monte Falco, 1658, Parco Foreste Casentinesi ;

            // rimuovo gli spazi
            List<string> vettetList2 = new List<string>();
            foreach (string item in ListVette)
            {
                vettetList2.Add(item.Trim());  // creo un altra lista senza spazi iniziali e finali
            };
            // >>>>>>> -------------------------------------------


            // creo lista  di oggetti classi 
            List<ClsVetta> ListVetteTot = new List<ClsVetta>();

            foreach (string item in vettetList2)
            {
                ClsVetta oVetta = new ClsVetta();
                oVetta.Nome = item.Split(',')[0].Trim();
                oVetta.Altezza = item.Split(',')[1].Trim();
                oVetta.Posizione = item.Split(',')[2].Trim();

                ListVetteTot.Add(oVetta);  //  lista con campi separati
            }


            // stampo il numero record
            Console.WriteLine(LinqUtils.GetMonte(ListVetteTot, "Monte Falco").Count());

            // stampo gli elementi trovati
            foreach (var myValue in LinqUtils.GetMonte(ListVetteTot, "Monte Falco"))
            {
                Console.WriteLine(myValue);
            }

        }
        
    }


}

class ClsVetta
{
    public string Nome
    { get; set; }
    public string Altezza
    { get; set; }

    public string Posizione
    { get; set; }

}

