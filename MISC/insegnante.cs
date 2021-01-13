using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
 

    public class insegnante : Customer
    {
        public insegnante(string firstname, string LastName) : base(firstname, LastName)
        {

        }

        public void ConvertToInt(string valore)  // Gestione errori
        {

            try
            {
                int numero = int.Parse(valore);
                Console.WriteLine("il numero è : " + numero);
                Console.WriteLine(1 / numero);
            }
            catch (FormatException err)
            {
                Console.WriteLine("errore di passaggio numero valido : " + valore);
                Console.WriteLine("errore  : " + err.Message + " " + err.Data + " " + err.StackTrace);
            }
            //catch (DivideByZeroException err)
            //{
            //    Console.WriteLine("errore di divisione x zero : " + valore);
            //    Console.WriteLine("errore  : " + err.Message + " " + err.Data + " " + err.StackTrace);
            //}
            catch (Exception err)  // altri errori 
            {  // altri errori
                Console.WriteLine("errore generico  : ");

                // Proprietà interessanti nella gestione dell'eccezione.
                Console.WriteLine("Message: " + err.Message);
                Console.WriteLine("Source: " + err.Source);
                Console.WriteLine("StackTrace: " + err.StackTrace);
                Console.WriteLine("Errot type= " + err.GetType());
            }

            //------------------------------------



        }



    }
}
