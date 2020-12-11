//
// istruzioni LINQ
// ORM 
// Search article.description ==param

//  from element in collection
//  where element =="qualcosa"
// select element 

using System.Collections.Generic;
using System.Linq;

namespace NExLinq
{
    class ExLinq
    {
        public static string Filtering()             // LINQ
        {

            string[] cities = new string[] { "Roma","Milano" };

            var query =
                from city in cities
                where city == "Roma"

                let cityTouppercase = city.ToUpper()

                select cityTouppercase;
            ////  END 
            ///
            return query.First();  // ritorna il primo record

            //IEnumerable<int>

                //IEnumerable < int >= query =
                //form number in numbers
                //where number == 45
                //    select number;
        }


        public static IEnumerable<string> FilteringAll()  // ritorna una query e si comporta come una lista
        {
            string[] cities = new string[] { "Roma", "Milano" };

            // LINQ

            var query =
                from city in cities
                where city == "Roma"

                let cityTouppercase = city.ToUpper()

                select cityTouppercase;
            ////  END 
            ///
            return query; 


        }

        //-----------------------------------

        public static IEnumerable<string> FilteringAll2()  // ritorna una query e si comporta come una lista
        {
            string[] cities = new string[] { "Roma", "Milano" };

            // LINQ

            IEnumerable<string> query =
                from city in cities
                where city == "Roma"

                let cityTouppercase = city.ToUpper()

                select cityTouppercase;
            ////  END 
            ///
            return query;  // ritonra il primo record


        }

        ///---------------------
        ///

        public static IEnumerable<string> GetCity(string myCity)  // ritorna un IEnumerable
        {
            List<string> namesList = new List<string> { "Arezzo", "Arezzo", "Siena", "Firenze", "Lucca" };

            IEnumerable<string> query =
              from city in namesList
              where city == myCity

              let cityTouppercase = city.ToUpper()

              select cityTouppercase;
            ////  END 
            ///
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
            ////  END 
            ///
            return query.ToList();  // ritorna la  query con lista




        }

    }

}