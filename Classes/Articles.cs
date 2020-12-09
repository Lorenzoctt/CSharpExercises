using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class Articles
    {


        private List<Article> myArticlesList;//= new List<Customer>(); // è possibile istanziare la lista nel costruttore

        public Articles() // COSTRUTTORE // è possibile istanziare la lista nel costruttore
        {
            this.myArticlesList = new List<Article>();
        }

        /// <summary>
        /// x aggiungere articoli (anche con metodo statico ?)
        /// </summary>
        public void Add(Article _article)
        {
            myArticlesList.Add(_article);
        }
        public int Count()
        {
            return myArticlesList.Count();
        }



        public void Delete(Article _article)  //OK funziona 
        {
            myArticlesList.Remove(_article);
        }
        public void Delete(int myIdArticle)  //OK funziona 
        {
            foreach (Article myArticle in myArticlesList)
            {
                

                if (myArticle.Id_article == myIdArticle) {
                    Console.WriteLine(myArticle.List()); }
            }
        }
        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void List()
        {

            // throw new System.NotImplementedException();
            foreach (Article myArticle in myArticlesList)
            {
                Console.WriteLine( myArticle.List());
            }
        }

        /// <summary>
        /// lista di articoli
        /// </summary>
        public void Retrive()  // ritorna un elemento dalla lista
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// cerca per descrizione e ritorna un solo articolo
        /// </summary>
        public void searchedArticle()
        {
            throw new System.NotImplementedException();
        }
    }
}
