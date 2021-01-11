

using System.Collections.Generic;
using System.Linq;
using System;



namespace NExLinq
{
    class LinqUtils
    {
        public static string Filtering()             // LINQ   ARRAY DI STRINGA  (solo 1 record)
        {

            string[] cities = new string[] { "Roma", "Milano" };

            IEnumerable<string> query =
                from city in cities
                where city == "Roma"

                let cityTouppercase = city.ToUpper()

                select cityTouppercase;

            return query.First();  // ritorna il primo record


        }


        public static IEnumerable<string> FilteringAll()  // ritorna una query di un campo e si comporta come una lista
        {
            string[] cities = new string[] { "Roma", "Milano" };

            // LINQ

            var query =
                from city in cities
                where city == "Roma"

                let cityTouppercase = city.ToUpper()

                select cityTouppercase;

            return query;


        }

        //-----------------------------------


        public static IEnumerable<string> GetCity(string myCity)  // ritorna un IEnumerable
        {
            List<string> namesList = new List<string> { "Arezzo", "Arezzo", "Siena", "Firenze", "Lucca" };

            IEnumerable<string> query =
              from city in namesList
              where city == myCity

              let cityTouppercase = city.ToUpper()

              select cityTouppercase;

            return query;  // ritorna la  query
        }

        public static List<string> GetCityList(string myCity) // ritorna una lista
        {
            List<string> namesList = new List<string> { "Arezzo", "Arezzo", "Siena", "Firenze", "Lucca" };

            IEnumerable<string> query =
              from city in namesList
              where city == myCity

              let cityTouppercase = city.ToUpper()

              select cityTouppercase;

            return query.ToList();  // ritorna la  query con lista
        }

        // KO
        public static IEnumerable<string> GetMonte(List<ClsVetta> ListTemp, string mypar)  // funzione che ritorna un IEnumerable
        {

            IEnumerable<string> query =
              from fieldtmp in ListTemp
              where fieldtmp.Nome == mypar

              select fieldtmp.Nome;

            return query;  // ritorna la  query
        }



        private   static  List<Macchina> QueryPiuCampi(int myCilindrata)  // QUERY CON PIU CAMPI RISULTATO
        {


            List<Macchina> MacchineList = new List<Macchina> { new Macchina { nome = "fiat", cilindrata = 1600 }, new Macchina { nome = "Opel", cilindrata = 1400 } };

            IEnumerable<Macchina> query =
             from elemento in MacchineList
             where elemento.cilindrata == myCilindrata

             select elemento;

            return query.ToList();  // ritorna la lista - query

        }

        public static void TestQueryPiucampi()
        {
            Console.WriteLine(QueryPiuCampi(1400).Count());
        }
  
      

        class Macchina
        {
            public string nome;
            public int cilindrata;


        }

    }

}