using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace ECommerce
{
    public class Article
    {
        // aggiunta campi privati
        private int? Id_article;
        private Decimal? Price;
        private string Description;
        private int? Stock;
        private Decimal? Tax;


        public Article(string _description, Decimal _price)
        {
            this.Description = _description;
            this.Price = _price;
        }

        public string List()
        {
            return this.Id_article + "\t" + this.Price + "\t" + this.Description + "\t" + this.Stock + "\t" + this.Tax;
        }



        public void Destroy(int _id)
        {
            if (this.Id_article == _id)  // verifico che sto distruggendo l'oggetto giusto
            {
                this.Id_article = null;
                this.Price = null;
                this.Description = null;
                this.Stock = null;
                this.Tax = null;
            }
            else Console.WriteLine("Id articolo errato");
        }

        public void Create(int _id_article, Decimal _price, string _description, int _stock, Decimal _tax)
        {
            this.Id_article = _id_article;
            this.Price = _price;
            this.Description = _description;
            this.Stock = _stock;
            this.Tax = _tax;


        }

        public void Update(int _id_article, Decimal _price, string _description, int _stock, Decimal _tax)
        {
            this.Id_article = _id_article;
            this.Price = _price;
            this.Description = _description;
            this.Stock = _stock;
            this.Tax = _tax;


        }

        public String Retrive(int _id)
        {
            if (this.Id_article == _id)  // verifico che sto distruggendo l'oggetto giusto
            {
                return this.Id_article + "\t" + this.Price + "\t" + this.Description + "\t" + this.Stock + "\t" + this.Tax;
            }
            else return null;
        }
    }


}
