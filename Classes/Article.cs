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
        public Decimal? Price;
        private string description;
        private Decimal? Tax;
        private int? stock;


        public int? Stock
        {
            get
            { return stock; }
            set
            {
                if (value > 0)
                {
                    stock = value;
                }
            }
        }



        public int Id_article
        {
            get
            { return id_article; }
            set
            { id_article = Id_article; }

        }

        public string Description
        {
            get { return description; }   // lo metto di sola lettura

        }

        public Article(string _description, Decimal _price)
        {
            
            this.description = _description;
            this.Price = _price;
        }
        public Article()
        {

        }



        public string List()
        {

            return this.Id_article + UtiCSV.sep + this.Price + UtiCSV.sep + this.Description + UtiCSV.sep + this.Stock + UtiCSV.sep + this.Tax;
        }



        public void Destroy(int _id)
        {
            if (this.Id_article == _id)  // verifico che sto distruggendo l'oggetto giusto
            {
                // this.id_article = null;
                this.Price = null;
                this.description = null;
                this.Stock = null;
                this.Tax = null;
            }
            else Console.WriteLine("Id articolo errato");


        }


        public void Update( Decimal _price, string _description, int _stock, Decimal _tax)
        {
            this.Price = _price;
            this.description = _description;
            this.Stock = _stock;
            this.Tax = _tax;
        }



        public  Article(string csvLine)  //  // valorizza l'articolo da una stringa contenente campi e separatori
        {
            string[] values = csvLine.Split(UtiCSV.sep);
          
            this.id_article = Convert.ToInt32(values[0]);
            this.Price = Convert.ToDecimal(values[1]);
            this.description = values[2];
            this.stock = UtiCSV.int32Nvl(values[3]);
            this.Tax = UtiCSV.decNvl(values[4]);
            
        }

    }


}
