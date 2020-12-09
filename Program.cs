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

            //funcList();
            //   CreateOrder(); //OK   Interaction between classes (#3)
            // TestCustomer();  //OK  test customer

            TestaArticoli();  // testa classi articlese articles

          //  funcConsole()  // esempio di utilizzo Console.WriteLine ReadKey

            if (false)
            { // non eseguo
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

            Article myArticle = new Article(1,"Videocassetta", (decimal)12.4);
            myArticle.Update(1, (decimal)12.4, "Videocassetta", 5, (decimal)22);

            //  OrderHeader myOrderHeader = new OrderHeader(myCustomer.Id_user);
            myCustomer.AddToCart(myArticle);


            Customers myCustomers = new Customers();

            myCustomers.Add(myCustomer);
            Console.WriteLine("numero clienti in lista: " + myCustomers.Count());
            myCustomers.List();


        }


        static void TestCustomer()  // esempi con customer
        {



            {
                Console.WriteLine("----------- avvio costruttore --------------------------------------------");

                // var firstCustomer = new Customer();  // in alternativa
                Customer firstCustomer = new Customer("Francesco", "Rossi"); // in alternativa

                //Richiamo il  costruttore per assegnare nome, cognome ed email all'oggetto.
                Customer myCustomer = new Customer("Francesco", "Rossi", "francesco.rossi@alice.it");

                Console.WriteLine(myCustomer.GetInfo());  //stampo as video alcuni valori dell'oggetto'
                                                          //-------

                //-------------  Interaction between classes (#3)
                myCustomer.Age = 15;  // restituisce in cosnole il messaggio di errore


            }

            Console.WriteLine($"Il numero dei clienti in anagrafico è {Customer.PrintSomething()}"); Customer.PrintSomething();  //utilizzo una funzione dichiaratacon  metodo statico e non ho necessità di creare l'istanza

            {






                //----------------------------
                IBasket ItmpBasket = new Basket();  // utilizzo interfaccia
                ItmpBasket.Buy();
                Basket tmpBasket = new Basket();
                tmpBasket.Buy();

            }
           

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

            Article myArticle1 = new Article(1, "Face mask", (decimal)12.44);
            Console.WriteLine(myArticle1.List());



            Console.WriteLine(myArticle1.List());
            myArticle1.Update(1, (decimal)12.5, "Face mask", 15, 22);

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

            Articles myArticles = new Articles();
            myArticles.Add(myArticle1);
            Console.WriteLine(myArticles.Count());
            //----
            Article myArticle2 = new Article(2, "cacciavite", (decimal)12.44);

            myArticles.Add(myArticle2);
            //----
            Article myArticle3 = new Article(3, "quaderno", (decimal)12.44);
            myArticles.Add(myArticle3);

            //----
            Article myArticle4 = new Article(4, "penna", (decimal)12.44);
            myArticles.Add(myArticle4);
            //----
            myArticles.Delete(myArticle2);
            Console.WriteLine(myArticles.Count());
            myArticles.Delete(myArticle3);

            myArticles.List();


        }
    }


}



