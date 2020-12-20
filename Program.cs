using System;
using System.Collections.Generic;
using ECommerce;  // x accedere alla classe
//using CSharpExercises; // accedere al namespace e classi
using NProgramLINQ;
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
        static void Main(string[] args)
        {

            Console.WriteLine("Premere un numero da 1 a 8 ");
            Console.WriteLine("7 Ordine completo ");
            Console.WriteLine("8 Lettura CSV ");

            ConsoleKeyInfo level = Console.ReadKey();


            switch (level.KeyChar)
            {
                case '1':
                    Console.WriteLine("funcList(;");
                    funcList();
                    break;
                case '2':
                    Console.WriteLine(" CreateOrder()");
                    CreateOrder();//OK   Interaction between classes (#3)
                    TestCustomer();  //OK  test customer e admin
                    break;
                case '3':
                    Console.WriteLine("testa classi article e articles (statico)");
                    TestaArticoli();  // testa classi article e articles (statico)
                    TestaArticoliBis();
                    break;
                case '4':
                    Console.WriteLine(" esempio di utilizzo Console.WriteLine ReadKey");
                    funcConsole();  // esempio di utilizzo Console.WriteLine ReadKey
                    break;
                case '5':
                    Console.WriteLine("prova Interface");
                    TestInferface();  //prova Interface
                    break;
                case '6':
                    Console.WriteLine("prova LINQ");
                    ProgramLINQ.TestLINQ();
                    ProgramLINQ.WorkLinq2(); // Working with LINQ pt2(#8)
                    break;
                case '7': // #9
                    CreateCompleteOrder();  // crea ordine completo
                    break;
                case '8': // 
                    LeggiFileCSV();
                    break;
                case 'q': // 
                    Environment.Exit(-1);
                    break;


            }





            if (false)  // non eseguo
            {
                // Scrivi un programma completo di namespace, che legge il tuo nome dagli argomenti di Main() e lo 
                // ristampa trasformandolo in uppercase.Carica le modifiche sul repo Github.
                if (args.Length > 0)
                {
                    Console.WriteLine($"Il parametro passato è {args[0]}");
                }
                else Console.WriteLine("Nessun parametro passato !");

            }




        }

        static void funcConsole()  // esempio di utilizzo Console.WriteLine ReadKey
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
        }

        static void CreateOrder()
        {
            //                Given two classes, Customer and Article:
            //create a new object of type Customer, which now should have also the age, set through a property. If the age is less 
            // than 18, the user should see a warning message in the console like "You might not be able to buy certain articles"
            //Then, make Customer and Article interact together so that:
            //	when a customer wants to make an order for an article, and the customer age is less than 18, the Article class should print a message

            Customer myCustomer = new Customer("Filippo", "Rossi");
            myCustomer.Age = 17;

            Article myArticle = new Article("Videocassetta", (decimal)12.4);
            myArticle.Update( (decimal)12.4, "Videocassetta", 5, (decimal)22);


            myCustomer.AddToCart(myArticle);

            Customers myCustomers = new Customers();

            myCustomers.Add(myCustomer);
            Console.WriteLine("numero clienti in lista: " + myCustomers.Count());


        }


        static void TestCustomer()  // esempi con customer e admin
        {



            {
                Console.WriteLine("----------- avvio costruttore --------------------------------------------");

                // var firstCustomer = new Customer();  // in alternativa
                Customer firstCustomer = new Customer("Francesco", "Rossi"); // in alternativa


                Customer myCustomer = new Customer("Francesco", "Rossi", "francesco.rossi@alice.it");

                Console.WriteLine(myCustomer.GetInfo());  //stampo as video alcuni valori dell'oggetto'
                                                          //-------

                //-------------  Interaction between classes (#3)
                myCustomer.Age = 15;  // restituisce in cosnole il messaggio di errore


            }

            Console.WriteLine($"Il numero dei clienti in anagrafico è {Customer.PrintSomething()}"); Customer.PrintSomething();  //utilizzo una funzione dichiaratacon  metodo statico e non ho necessità di creare l'istanza

            // test classe admin

            Admin myAdmin = new Admin();

            myAdmin.SetAdministrator(true);
            myAdmin.RegUser("lore", "cccc", "ore@aaa");

            Console.WriteLine("myAdmin.Id_user: " + myAdmin.Id_user);




        }


        static void TestInferface()
        {
            //----------------------------
            IBasket ItmpBasket = new Basket();  // utilizzo interfaccia
            ItmpBasket.Buy();

            Basket tmpBasket = new Basket(); // utilizzo classe
            tmpBasket.Buy();
        }


        static void funcList()  // utilizzo di una lista 
        {

            var namesList = new List<string> { "Aldo", "filippo", "giovanni" };
            foreach (var name in namesList)
            {
                Console.WriteLine($"Hello {name.ToLower()}");
            }
        }

        static void TestaArticoli()
        {
            // avvio il costruttore

            Article myArticle1 = new Article("Face mask", (decimal)12.44);
            Console.WriteLine(myArticle1.List());



            Console.WriteLine(myArticle1.List());
            myArticle1.Update( (decimal)12.5, "Face mask", 15, 22);

            Console.WriteLine(myArticle1.List());

            Console.WriteLine("Avvio distruzione oggetto");
            myArticle1.Destroy(1);

            Console.WriteLine(myArticle1.List());
            myArticle1.Stock = 200;
            Console.WriteLine(myArticle1.List());


            //{  // utilizzo di una lista di articoli esterna
            //    List<Article> myArticlelist = new List<Article>()
            //    {
            //        new Article(1, "Face mask",  (decimal)44.5 ),
            //        new Article( 2,"trapano",  (decimal)57.5 )

            //    };

            //    foreach (Article c in myArticlelist)
            //        System.Console.WriteLine(c.List());//scorro e stampo a video il contenuto della lista
            //}

            //Articles myArticles = new Articles();
            //myArticles.Add(myArticle1);
            //Console.WriteLine(myArticles.Count());
            ////----
            //Article myArticle2 = new Article(2, "cacciavite", (decimal)12.44);

            //myArticles.Add(myArticle2);
            ////----
            //Article myArticle3 = new Article(3, "quaderno", (decimal)12.44);
            //myArticles.Add(myArticle3);

            ////----
            //Article myArticle4 = new Article(4, "penna", (decimal)12.44);
            //myArticles.Add(myArticle4);
            ////----
            ///
            //-------------------------------------------

            Articles.Add(myArticle1);
            Console.WriteLine(Articles.Count());
            //----
            Article myArticle2 = new Article("cacciavite", (decimal)12.44);

            Articles.Add(myArticle2);
            //----
            Article myArticle3 = new Article("quaderno", (decimal)12.44);
            Articles.Add(myArticle3);

            //----
            Article myArticle4 = new Article("penna", (decimal)12.44);
            Articles.Add(myArticle4);
            //----
            //--------------------------------------

            Articles.Delete(myArticle2);
            Console.WriteLine(Articles.Count());
            Articles.Delete(myArticle3);

            Articles.List();

            //--
            Article myArticleSearched = Articles.SearchArticle("penna"); //Finishing the ecommerce structure (#6)
            Console.WriteLine("l'id ricercato è " + myArticleSearched.Id_article);
            Articles.Delete(4);  // CANCELLO PER ID


        }

        static void TestaArticoliBis()
        {



            Console.WriteLine(Articles.Count());


        }


        static void CreateCompleteOrder()
        {

            // conteggio i numeri di articoli del file csv valorizzando  la lista articles
            Console.WriteLine("il numero di articoli è :" + Articles.Count());

            //Milestone 1
            Customer myCustomer1 = new Customer("Francesco", "Rossi", "francesco.rossi@alice.it");
            Customer myCustomer2 = new Customer("Alberto", "Bianchi", "alberto.bianchi@alice.it");
            Admin myAdmin = new Admin();
            myAdmin.SetAdministrator(true);
            myAdmin.RegUser("lore", "ctt", "lore@aaa");


            //Milestone 2
            Articles.List();

            Article myArticle1 = new Article("Videocassetta", (decimal)12.4);
            Articles.Add(myArticle1);


            Article myArticle2 = new Article("martello", (decimal)90.0);
            Articles.Add(myArticle2);

            Article myArticle3 = new Article("pinza", (decimal)10.5);
            Articles.Add(myArticle3);

            Articles.List();

            Console.WriteLine($"stampo in console il prezzo del martello: {Articles.SearchArticle("martello").Price}");
            Console.WriteLine("adesso il numero di articoli è :" + Articles.Count());
            //-----------

            //Milestone 3
            Basket Basket1 = new Basket();
            Basket1.Add(myArticle1, 20, myCustomer1);  //aggiungo un articolo nel carrello
      
            Baskets.AddtoList(Basket1);  


            ///  -------------------------------
            Article myart = new Article();
            myart = Articles.SearchArticle("martello");  // ricerco una descrizione e ritorno un articolo Milestone 2

            Basket Basket2 = new Basket();
            Basket2.Add(myart, 20, myCustomer1);  //Creo e valorizzo il basket
            Baskets.AddtoList(Basket2);           // aggiungo il basket alla lista  
            //-------------

            Baskets.ElencaTutti();  // elenca gli articoli inseriti del basket
            // -----   

            Console.WriteLine($"-----   prezzo totale del cliente myCustomer1 è =   {Baskets.TotalPrice(myCustomer1)}");
           
            //-----------------------
            // esercizio 10
            Articles.WriteToFileCSV();  // SALVA LA LISTA ARTICOLI

            Baskets.WriteToFileCSV(); // SALVA LA LISTA DEL CARRELLO


            //-------------------


        }


        public static void testAggregate()
        {
            // >>>> ---------------------    test reduce
            List<LEZARTICOLI> prices = new List<LEZARTICOLI>();
            //  prices.Sum();

            List<LEZARTICOLI> myListPippo = new List<LEZARTICOLI>();

            LEZARTICOLI myPippo = new LEZARTICOLI();
            LEZARTICOLI myPippo2 = new LEZARTICOLI();
            // errore da qui       var total = prices.Aggregate(0.00, (acc, val) => acc + val.Price);

            // <<<< test Aggregate

        }


        public static void LeggiFileCSV()
        {
            var lines = File.ReadAllLines(UtiCSV.orderDetailPath);

            var query =
                from line in lines
                let row = line.Split(",")
                let fourthColum = row[3]

                select int.Parse(fourthColum);


            Console.WriteLine("-----------------------");
            Console.WriteLine(query.Sum());




        }





    }


}



