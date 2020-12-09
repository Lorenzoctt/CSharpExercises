using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public  class Articles  
    {


        private static  List<Article> myArticlesList= new List<Article>(); // è possibile istanziare la lista nel costruttore



        /// <summary>
        /// x aggiungere articoli (anche con metodo statico ?)
        /// </summary>
        public static void Add(Article _article)  // metodi e proprietà statica che non necessita di istanziarla ma sempre visibile in ogni parte del programma
        {
            myArticlesList.Add(_article);
        }
        public static int Count()
        {
            return myArticlesList.Count();
        }



        public static void Delete(Article _article)  //OK funziona 
        {
            myArticlesList.Remove(_article);
        }
        public static void Delete(int myIdArticle)  //OK funziona 
        {
            foreach (Article myArticle in myArticlesList)
            {


                if (myArticle.Id_article == myIdArticle)
                {
                    Console.WriteLine("CANCELLAZIONE : " +myArticle.List());
                    myArticlesList.Remove(myArticle);
                    return;  //esco dal ciclo perchè la lista è cambiata e ilprossimo giro darebbe errore


                }
            }
        }
        public static void Update()
        {
            throw new System.NotImplementedException();
        }

        public static void List()
        {

            // throw new System.NotImplementedException();
            foreach (Article myArticle in myArticlesList)
            {
                Console.WriteLine(myArticle.List());
            }
        }

        /// <summary>
        /// lista di articoli
        /// </summary>
        public static void Retrive()  // ritorna un elemento dalla lista
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// cerca per descrizione e ritorna un solo articolo
        /// </summary>
        public static Article Search(string myDescription )
        {
            foreach (Article tmpArticle in myArticlesList)
            {
                if (tmpArticle.Description == myDescription)
                {
                    return tmpArticle;
                }
              
            }
               return null;
        }
    }
}
