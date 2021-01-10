using System;
using System.Collections.Generic;
using ECommerce;  // x accedere alla classe
//using CSharpExercises; // accedere al namespace e classi

using System.IO;
using System.Linq;



namespace CSharpExercises
{
    class LEZARTICOLI
    {
        //public double Price { get ; set ; }
        public double Price { get; } = 45;
        public string PriceDescription = "descrizione";

    }

    class Program
    {
        private static Customer myCustomer = new Customer("Francesco", "Rossi", "francesco.rossi@alice.it");  // TODO FARE FUNZIONE LOGIN
        static void Main(string[] args)
        {


            if (false)  // non eseguo   // rilevo i parametri ricevuti
            {
                // Scrivi un programma completo di namespace, che legge il tuo nome dagli argomenti di Main() e lo 
                // ristampa trasformandolo in uppercase.Carica le modifiche sul repo Github.
                if (args.Length > 0)
                {
                    Console.WriteLine($"Il parametro passato è {args[0]}");
                }
                else
                    Console.WriteLine("Nessun parametro passato !");
            }



            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }





        }



        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Scegli una opzione :");
            Console.WriteLine("1) Lista articoli ");
            Console.WriteLine("2) Inserimento articolo  ");
            Console.WriteLine("3) Ricerca articolo per descrizione");
            Console.WriteLine("4) Cancellazione articolo ");
            Console.WriteLine("5) Inserimento articolo nel carrello  ");
            //Console.WriteLine("6) Lista del carrello >>TODO");
            //Console.WriteLine("7) Crea ordine ");
            //Console.WriteLine("8) ");
            //Console.WriteLine("9) ");
            Console.WriteLine("---------------------");
            Console.WriteLine("11) Test Vari ");
            Console.WriteLine("q) Esci");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("LISTA ARTICOLI :");
                    Articles.List();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("2) Inserimento articolo  ");
                    CreaArticolo();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Ricerca per descrizione");
                    RicercaArticolo();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.WriteLine("Cancellazione articolo in anagrafica ");
                    CancellaArticolo();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.Clear();
                    Console.WriteLine("5) Inserimento articolo nel carrello  ");
                    AddToBasket();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();

                    return true;

                case "6":
                    Console.Clear();
                    Console.WriteLine("TODO");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;

                case "7":
                    Console.Clear();
                    Console.WriteLine("TODO");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    Console.WriteLine("TODO");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;

                case "9": //
                    Console.Clear();
                    Console.WriteLine("TODO");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;

                case "10":
                    Console.Clear();
                    Console.WriteLine("TODO");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "11":
                    Console.Clear();
                    return CodiceVarioTest.MainMenuTestVari();


                case "q":
                    return false;
                default:
                    return true;
            }

        }


        static void RicercaArticolo()
        {
            string descrizione;
            Console.WriteLine("Inserisci la descrizione esatta");
            descrizione = Console.ReadLine();


            Article myArticleSearched = Articles.SearchArticle(descrizione); //Finishing the ecommerce structure (#6)
            if (!(myArticleSearched == null))
            {
                Console.WriteLine("l'id ricercato è " + myArticleSearched.Id_article);
                Console.WriteLine("elenco campi: ");
                Console.WriteLine(myArticleSearched.List());
            }
            else Console.WriteLine("Articolo non trovato");

        }

        static void CancellaArticolo()
        {
            int idArticolo;
            Console.WriteLine("Inserisci il codice articolo");


            bool success = int.TryParse(Console.ReadLine(), out idArticolo);
            if (success)
            {

                if (Articles.Delete(idArticolo))
                {  // CANCELLO PER ID
                    Console.WriteLine("Articolo cancellato");
                }
                else Console.WriteLine("Articolo non trovato");
            }
            else Console.WriteLine("Valore errato");

        }

        static void CreaArticolo()
        {
            decimal prezzo;
            string descrizione;
            Console.WriteLine("Inserisci la descrizione :");
            descrizione = Console.ReadLine();
            Console.WriteLine("Inserisci il prezzo : ");
            prezzo = decimal.Parse(Console.ReadLine());  // TODO gestire eccezioni

            Article myArticle1 = new Article(descrizione, prezzo);
            Articles.Add(myArticle1);
            Articles.List();
        }


        private static void AddToBasket()
        {
            int quantita = 1;
            string descrizione;

            Console.WriteLine("Inserisci la descrizione :");
            descrizione = Console.ReadLine();
            Console.WriteLine("Inserisci la quantita :");
            quantita = int.Parse(Console.ReadLine());

            Article myArticleSearched = Articles.SearchArticle(descrizione); //Finishing the ecommerce structure (#6)


            if (!(myArticleSearched == null))
            {
                Console.WriteLine("l'id ricercato è " + myArticleSearched.Id_article);
                Basket myBasket = new Basket(myArticleSearched, quantita, myCustomer);

                Baskets.AddtoList(myBasket);

                Baskets.List();
                Console.WriteLine($"{descrizione} aggiunto al basket");

            }
            else Console.WriteLine($"{descrizione} non trovato");

            Baskets.List();
        }




    }


}



