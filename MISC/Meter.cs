using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public abstract class Meter
    {
       

        public abstract decimal Speed(decimal distance, decimal time);

        public decimal ConvertToEnglishSpeed(decimal VelIta)
        { return VelIta / (decimal)1.609344; }

        public decimal ConvertToItalianSpeed(decimal VelEng)
        { return VelEng * (decimal)1.609344; }



    }

    public class EnglishMeter : Meter
    {
        // miglia orari
        public override decimal Speed(decimal distance, decimal time)


        {
           
            
            
            return distance / time / 1000 * 3600; }


    }

    public class ItalianhMeter : Meter
    {


        public override decimal Speed(decimal distance, decimal time)

            // mt   e secondi  
            //3600= 1 ora
        {
            
            decimal km = distance / 1000;
            decimal ore = time / 3600; 


            return km / ore ; }


    }

}