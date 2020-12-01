using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class Basket: IBasket
    {

        
        private int Id_basket
        {
            get => default;
            set
            {
            }
        }

        private int Id_Article
        {
            get => default;
            set
            {
            }
        }

        private int Quantity
        {
            get => default;
            set
            {
            }
        }

        private int Id_User
        {
            get => default;
            set
            {
            }
        }

        public Basket()//costruttore
        {

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

        public void List()
        {
            Console.WriteLine("elenco l'ordine");
            //throw new System.NotImplementedException();
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }
    }
}