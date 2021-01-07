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
        private  static   Customer myCustomer = new Customer("Francesco", "Rossi", "francesco.rossi@alice.it");  // TODO FARE FUNZIONE LOGIN
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
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Lista articoli ");
            Console.WriteLine("2) Inserimento articolo  ");
            //Console.WriteLine("3) ricerca articolo per descrizione  >>TODO");
            //Console.WriteLine("4) cancellazione articolo  >>TODO");
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
                    Console.WriteLine("LISTA ARTICOLI :");
                    Articles.List();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "2":
                    CreaArticolo();
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "3":
                    Console.WriteLine("TODO");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.WriteLine("TODO");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "5":
                    AddToBasket();
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();

                    return true;

                case "6":
                    Console.WriteLine("TODO");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;

                case "7":
                    Console.WriteLine("TODO");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.WriteLine("TODO");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;

                case "9": // 
                    Console.WriteLine("TODO");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;

                case "10":
                    Console.WriteLine("TODO");
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                    return true;
                case "11":
                    return CodiceVarioTest.MainMenuTestVari();


                case "q":
                    return false;
                default:
                    return true;
            }

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

            Article myArticleSearched = Articles.SearchArticle(descrizione); //Finishing the ecommerce structure (#6)
            Console.WriteLine("l'id ricercato è " + myArticleSearched.Id_article);
            if (!(myArticleSearched == null))
            {
                Basket myBasket = new Basket();
                myBasket.Add(myArticleSearched, quantita, myCustomer);

                Baskets.AddtoList(myBasket);

                Baskets.List();
                Console.WriteLine($"{descrizione} aggiunto al basket");

            }
            else Console.WriteLine($"{descrizione} non trovato");
        }




    }


}



