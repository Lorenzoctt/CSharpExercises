using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace ECommerce
{


    public class Article

    {
        // aggiunta campi privati
        private int id_article;
        private Decimal? Price;
        private string Description;
        private Decimal? Tax;



        private int? stock;
        public int? Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value > 0)
                {
                    stock = value;
                }
            }
        }

        public int Property
        {
            get => default;
            set
            {
            }
        }

        public int Id_article
        {
            get
            {
                return id_article;
            }
            set
            {
                id_article = Id_article;
            }

        }

        public Article(int _id_article, string _description, Decimal _price)
        {
            this.id_article = _id_article;
            this.Description = _description;
            this.Price = _price;
        }
        public Article()
        {

        }



        public string List()
        {
            return this.Id_article + "\t" + this.Price + "\t" + this.Description + "\t" + this.Stock + "\t" + this.Tax;
        }



        public void Destroy(int _id)
        {
            if (this.Id_article == _id)  // verifico che sto distruggendo l'oggetto giusto
            {
                // this.id_article = null;
                this.Price = null;
                this.Description = null;
                this.Stock = null;
                this.Tax = null;
            }
            else Console.WriteLine("Id articolo errato");
        }

        public void Create(int _id_article, Decimal _price, string _description, int _stock, Decimal _tax)
        {
            this.id_article = _id_article;
            this.Price = _price;
            this.Description = _description;
            this.Stock = _stock;
            this.Tax = _tax;


        }

        public void Update(int _id_article, Decimal _price, string _description, int _stock, Decimal _tax)
        {
            this.id_article = _id_article;
            this.Price = _price;
            this.Description = _description;
            this.Stock = _stock;
            this.Tax = _tax;
        }


    }


}
