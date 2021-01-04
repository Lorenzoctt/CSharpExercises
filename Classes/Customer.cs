using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace ECommerce
{
    public class Customer
    {

        // >>>> FIELDS OR ATTRIBUTES

        private int id_user;
        private string FirstName;
        private String LastName;
        private int Address;
        private int Cap;
        private string City;
        private string Email; //  meglio mettere una classe email per ottenere la validazione
        private string Password; // meglio mettere una proprità asc nascosta
        protected int age;



        // COSTRUTTORE
        public Customer(string firstname, string LastName)
        {
            this.FirstName = firstname;
            this.LastName = LastName;
            this.id_user = Customers.NewId();
        }


        // costruttore per assegnare nome, cognome ed email agli attributi campi della classe
        public Customer(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.id_user = Customers.NewId();
        }
        public Customer() { }


        public int Age   //Interaction between classes(#3)
        {
            get { return age; }
            set
            {
                if (value < 18)
                { Console.WriteLine("You might not be able to buy certain articles"); }
                age = value;
            }
        }

        public int Id_user
        {
            get { return id_user; }

        }








        //<<<<<<<<<<<<<<<------------------- 

        public bool Login(string myPassword)
        {
            //throw new System.NotImplementedException();

            Console.WriteLine("You are Logged : " + myPassword);
            Console.WriteLine($"Hi you are Logged : {this.FirstName}");
            // da implementare
            return true;
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }

        public void RegUser(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            id_user = Customers.NewId();   // TODO  da implementare autogenerazione

        }


        public void AddToCart(Article _article)

        {
            if (this.age < 18)
            {
                Console.WriteLine("You might not be able to buy certain articles");
            }
            else
                Console.WriteLine("Articolo aggiunto: " + _article.List());

            // da implementare
            //  return true;
        }

        public static int PrintSomething()  // funzione statica , è possibile accederci anche senza istanziare l'oggetto
        {
            return 1000; //ritorno il numero dei clienti
        }

        public string GetInfo()
        {    //ritorno 3 valori 
            return this.FirstName + "," + this.LastName + "," + this.Email;
        }
    }

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


