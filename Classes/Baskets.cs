using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ECommerce
{
    public class Baskets
    {
        private static List<Basket> myBasketList = new List<Basket>();
        private static int globalID;




        public static int NewId()  //TODO da definire criterio di crezione globalID  (per utente ?)
        {
            globalID = ++globalID;
            return globalID;
        }

        public static new void List()
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
            WriteToFileCSV();

        }




        public static double TotalQuantity(Customer myCustomer)
        {

            int value =
                  (from element in myBasketList
                   where element.Id_User == myCustomer.Id_user

                   select element.Quantity).Sum();

            return Convert.ToDouble(value);  // ritorna la  query
        }


        public static double TotalPrice(Customer myCustomer)  // eseguo la query sulle 2 liste e calcolo il prezzo per cliente 
        {


            IArticles ListaArticoli = new Articles();

           // ListaArticoli.GetList();


            decimal value =
              (from myBasket in myBasketList
               join myArticle in ListaArticoli.GetList() on myBasket.Id_User equals myArticle.Id_article
               where myBasket.Id_User == myCustomer.Id_user

               select Convert.ToDecimal(myBasket.Quantity) * Convert.ToDecimal(myArticle.Price)).Sum();


            //decimal value =
            //      (from myBasket in myBasketList
            //       join myArticle in IArticles.GetList on myBasket.Id_User equals myArticle.Id_article
            //       where myBasket.Id_User == myCustomer.Id_user

            //       select Convert.ToDecimal(myBasket.Quantity) * Convert.ToDecimal(myArticle.Price)).Sum();
            //----------------

            return Convert.ToDouble(value);  // ritorna il valore
        }

        private static void WriteToFileCSV()  // salvo la lista nel file 
        {
            string tempData = "";
            foreach (Basket item in myBasketList)
            {
                tempData = tempData + item.List() + Environment.NewLine;
            }

            // TODO SOVRASCRIVO  , DA VERIFICARE SE CORRETTO
            File.WriteAllText(UtiCSV.basketPath, tempData); //   SOSTITUISCE SEMPRE //System.UnauthorizedAccessException su estensioni conosciute

            //File.AppendAllText(path, tempData);


        }
    }

}
