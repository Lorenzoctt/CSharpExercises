using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class Basket : IBasket
    {
        private int id_basket;
        private int Id_Article;
        public int Quantity;
        public int Id_User;




        public int Id_basket
        {
            get { return id_basket; }

        }

        public Basket()//costruttore
        {
            //  this.myBasketList = new List<Basket>();



        }


        public void SetEmpy()
        {
            throw new System.NotImplementedException();
        }

        public void Buy()
        {
            // throw new System.NotImplementedException();
            Console.WriteLine("Ordine completato");
        }



        public string Detail()
        {
            return this.Id_basket + "\t\t" + this.Id_Article + "\t\t" + this.Id_User + "\t\t" + this.Quantity;
        }

        /// <summary>
        /// passando l'articolo e l'utente aggiunge l'articolo
        /// </summary>
        /// 



        public void Add(in Article myArticle, int myQta, in Customer myCustomer)
        {

            this.id_basket = Baskets.NewId();
            this.Id_Article = myArticle.Id_article;
            this.Quantity = myQta;
            this.Id_User = myCustomer.Id_user;


            //   Baskets.AddtoList(this);// TODO
        }


        public string List()
        {
            return this.Id_Article + "\t" + this.id_basket + "\t" + this.Id_User + "\t" + this.Quantity;
        }






    }

    public class Baskets : Articles
    {
        private static List<Basket> myBasketList = new List<Basket>();
        private static int globalID;

        public static int NewId()  //TODO da definire criterio di crezione globalID  (per utente ?)
        {
            globalID = ++globalID;
            return globalID;
        }

        public void List()
        {
            foreach (Basket myBasket in myBasketList)
            {
                Console.WriteLine(myBasket.Detail());
            }
        }

        public static void ElencaTutti()
        {

            if (myBasketList.Count() > 0)
            {
                Console.WriteLine("Id_basket" + "\t" + "Id_Article" + "\t" + "Id_User" + "\t" + "Quantity");
                foreach (Basket myBasket in myBasketList)
                {
                    Console.WriteLine(myBasket.Detail());

                }
            }
            else
                Console.WriteLine("Nessun articolo presente nel carrello");
        }

        public static void AddtoList(Basket mybasket)  //aggiunge un basket nella lista
        {
            myBasketList.Add(mybasket);



        }




        //public static double TotalPrice(Customer myCustomer)
        //{

        //    int value =
        //          (from element in myBasketList
        //           where element.Id_User == myCustomer.Id_user

        //           select element.Quantity).Sum();

        //    return Convert.ToDouble(value);  // ritorna la  query
        //}

        public static double TotalPrice(Customer myCustomer)  // eseguo la query sulle 2 liste e calcolo il prezzo per cliente 
        {

            decimal value =
                  (from myBasket in myBasketList
                   join myArticle in myArticlesList on myBasket.Id_User equals myArticle.Id_article
                   where myBasket.Id_User == myCustomer.Id_user

                   select Convert.ToDecimal(myBasket.Quantity)* Convert.ToDecimal(myArticle.Price)).Sum();

            return Convert.ToDouble(value);  // ritorna il valore
        }

    }


}
