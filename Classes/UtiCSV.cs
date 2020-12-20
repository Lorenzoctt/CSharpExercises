using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    class UtiCSV
    {
        public const string sep = ";";   // separatore x file CSV
        public const string articlePath = @"C:\Users\Lorenzo\Desktop\EserciziC#\CSharpExercises\Data\Articles.csv";
        public const string orderDetailPath = @"C:\Users\Lorenzo\Desktop\EserciziC#\CSharpExercises\Data\orderDetail-details.csv";
        public const string basketPath = @"C:\Users\Lorenzo\Desktop\EserciziC#\CSharpExercises\Data\Baskets.csv";

        public static Decimal? decNvl(string testo)
        {
            if (testo == "")
            {
                return null;
            }
            else
            {
                return Decimal.Parse(testo);
            }
        }

        public static Int32? int32Nvl(string testo)
        {
            if (testo == "")
            {
                return null;
            }
            else
            {
                return Int32.Parse(testo);
            }
        }
    }
}

