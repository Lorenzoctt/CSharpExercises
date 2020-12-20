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



        private static List<Article> LoadArticles() //  carica la lista dal file CSV 
        {

            // https://docs.microsoft.com/it-it/dotnet/csharp/programming-guide/concepts/linq/how-to-compute-column-values-in-a-csv-text-file-linq


            //--------------------------

            if (File.Exists(UtiCSV.articlePath))
            {
                string[] csvlines = File.ReadAllLines(UtiCSV.articlePath);

                List<Article> CSVList = File.ReadAllLines(UtiCSV.articlePath)
                                         //.Skip(1)  salta la prima linea
                                         .Select(v => Articles.FromCsv(v))
                                         .ToList();
                return CSVList;
            }

            return null;
        }

        public static Article FromCsv(string v)  // creo un articolo dalla stringa 
        {
            Article tempArticle = new Article(v);
            return tempArticle;
        }


        /// <summary>
        /// OK x aggiungere articoli nella lista (anche con metodo statico ?)
        /// </summary>
        public static void Add(Article _article)  // metodi e proprietà statica che non necessita di istanziarla ma sempre visibile in ogni parte del programma
        {
            if (!IsIdArticlePresent(_article.Description))
            {
                _article.Id_article = NewId(); //trovo e valorizzo l'ID
                myArticlesList.Add(_article);
                Console.WriteLine("Articolo <" + _article.Description + "> inserito nel database !");
            }
            else
                Console.WriteLine("Articolo <" + _article.Description + "> già presente nel database");
        }
        public static int NewId()  // cerco l'ultimo numero inserito e lo incremento
        {
            if (myArticlesList.Count() > 0)
            {
                int ret = (
               from fieldtmp in myArticlesList
               select (fieldtmp.Id_article)).Max();
                return ret + 1;
            }
            else
                return 1;
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

        public static Boolean IsIdArticlePresent(string myDescription)  // ricerco per descrizione 
        {
            int ret = (
            from fieldtmp in myArticlesList
            where fieldtmp.Description == myDescription

            select fieldtmp.Description).Count();



            return (ret > 0);
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
