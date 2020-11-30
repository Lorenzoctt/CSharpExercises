using System;
using System.Collections.Generic;
using ECommerce;  // x accedere alla classe
//using CSharpExercises; // accedere al namespace e classi



namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            {  // mio esempio
                string aFriend = "Bill";
                Console.WriteLine($"Hello {aFriend}");
                Console.Write("Premi un tasto per proseguire");
                Console.ReadKey();




                string nowDate = DateTime.Today.Date.ToString(("dd/MM/yyyy")), nowHour = DateTime.Now.ToString("HH:mm:ss");
                Console.WriteLine($"Oggi è il  {nowDate} e sono le ore {nowHour}");
            }
            {

                //   Scrivi un programma completo di namespace, che legge il tuo nome dalla console e lo ristampa 
                //    trasformandolo in uppercase.Carica le modifiche sul repo Github.
                Console.WriteLine("Immetti il tuo nome");
                string retName = Console.ReadLine().ToUpper();
                Console.WriteLine($"Ciao {retName}");

            }
            {
                // Scrivi un programma completo di namespace, che legge il tuo nome dagli argomenti di Main() e lo 
                // ristampa trasformandolo in uppercase.Carica le modifiche sul repo Github.
                if (args.Length > 0)
                {
                    Console.WriteLine($"Il parametro passato è {args[0]}");
                }
                else Console.WriteLine("Nessun parametro passato !");
            }


            {
                Console.WriteLine("----------- avvio costruttore --------------------------------------------");

                // var firstCustomer = new Customer();  // in alternativa
                Customer firstCustomer = new Customer("Francesco", "Rossi"); // in alternativa

                //Richiamo il  costruttore per assegnare nome, cognome ed email all'oggetto.
                Customer myCustomer = new Customer("Francesco", "Rossi", "francesco.rossi@alice.it");

                Console.WriteLine(myCustomer.GetInfo());  //stampo as video alcuni valori dell'oggetto'



            }

            Console.WriteLine($"Il numero dei clienti in anagrafico è {Customer.PrintSomething()}"); Customer.PrintSomething();  //utilizzo una funzione dichiaratacon  metodo statico e non ho necessità di creare l'istanza

            {
                // avvio il costruttore

                Article myArticle = new Article("Face mask", (decimal)12.44);
                Console.WriteLine(myArticle.List());

               

                Console.WriteLine(myArticle.List());
                myArticle.Update(1, (decimal)12.5, "Face mask", 15, 22);

                Console.WriteLine(myArticle.Retrive(1));

                Console.WriteLine("Avvio distruzione oggetto");
                myArticle.Destroy(1);

                Console.WriteLine(myArticle.Retrive(1));


                {  // utilizzo di una lista di articoli
                    List<Article> myArticlelist = new List<Article>()
                    {
                        new Article( "Face mask",  (decimal)44.5 ),
                        new Article( "trapano",  (decimal)57.5 )

                    };

                    foreach (Article c in myArticlelist)
                        System.Console.WriteLine(c.List());//scorro e stampo a video il contenuto della lista
                }

            }

        }










    }
}



