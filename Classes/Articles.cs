using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ECommerce
{
    public class Articles
    {


        private static int id_article;

        protected static List<Article> myArticlesList = LoadArticles(); // new List<Article>(); // è possibile istanziare la lista nel costruttore



        private static List<Article> LoadArticles()  // carica la lista dal file CSV 
        {


            myArticlesList = new List<Article>();


            // TODOD  agggiungere lettura file csv -----------------------
            // https://docs.microsoft.com/it-it/dotnet/csharp/programming-guide/concepts/linq/how-to-compute-column-values-in-a-csv-text-file-linq



            //--------------------------

            if (File.Exists(UtiCSV.articlePath))
            {
                string[] csvlines = File.ReadAllLines(UtiCSV.articlePath);
            }


            // TODO : DA POPOLARE  LA LISTA  myArticlesList DA CSV





            //--------------------------------------------------------------
            //   Console.WriteLine(query);

            return myArticlesList;



        }


        /// <summary>
        /// OK x aggiungere articoli (anche con metodo statico ?)
        /// </summary>
        public static void Add(Article _article)  // metodi e proprietà statica che non necessita di istanziarla ma sempre visibile in ogni parte del programma
        {
            myArticlesList.Add(_article);
        }
        public static int NewId()
        {
            if (id_article == 0)
            {
                id_article = 1;
            }
            else { id_article = ++id_article; }

            return id_article;
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
                    Console.WriteLine("CANCELLAZIONE : " + myArticle.List());
                    myArticlesList.Remove(myArticle);
                    return;  //esco dal ciclo perchè la lista è cambiata e ilprossimo giro darebbe errore


                }
            }
        }
        public static void Update()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// OK printing to console is enough
        /// </summary>
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
        public static Article SearchArticle(string myDescription)
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


        public static void WriteToFileCSV()  // salvo la lista nel file 
        {
            string tempData = "";
            foreach (Article item in myArticlesList)
            {
                tempData = tempData + item.List() + Environment.NewLine;
            }

            File.WriteAllText(UtiCSV.articlePath, tempData); //   SOSTITUISCE SEMPRE System.UnauthorizedAccessException su estensioni conosciute

            //File.AppendAllText(ArticlePath, tempData);


        }



    }
}
