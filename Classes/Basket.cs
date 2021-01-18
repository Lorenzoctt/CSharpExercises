using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;


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
        }

        public Basket(in Article myArticle, int myQta, in Customer myCustomer)
        {

            this.id_basket = Baskets.NewId();
            this.Id_Article = myArticle.Id_article;
            this.Quantity = myQta;
            this.Id_User = myCustomer.Id_user;

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
            return this.Id_basket + UtiCSV.sep + this.Id_Article + UtiCSV.sep + this.Id_User + UtiCSV.sep + this.Quantity;
        }

        /// <summary>
        /// passando l'articolo e l'utente aggiunge l'articolo
        /// </summary>
        /// 



        //public void Add(in Article myArticle, int myQta, in Customer myCustomer)
        //{

        //    this.id_basket = Baskets.NewId();
        //    this.Id_Article = myArticle.Id_article;
        //    this.Quantity = myQta;
        //    this.Id_User = myCustomer.Id_user;


        
        //}



        public string List()
        {
            return this.Id_Article + UtiCSV.sep + this.id_basket + UtiCSV.sep + this.Id_User + UtiCSV.sep + this.Quantity;
        }



    }



}
