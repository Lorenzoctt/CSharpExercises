﻿using System;
using EXLinq;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce
{
    class ProgramLINQ
    {
        static void TestLINQ()
        {

            Console.WriteLine("LINQ");


            // utilizzo IE
            IEnumerable<string> myIE = Enumerable.Empty<string>();
            myIE = ExLinq.GetCity("Arezzo");
            Console.WriteLine(myIE.First());
            //---------------------------------------



            // Utilizzo la LIST
            Console.WriteLine(ExLinq.GetCityList("Arezzo").Count);
            Console.WriteLine(ExLinq.GetCityList("Arezzo")[0]);




        }
    }
}
