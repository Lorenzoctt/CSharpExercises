using System;

namespace ECommerce
{
    class Customer
    {

        // Visibilità -- valore di ritorno  -- Nomemetodo
        //FIELDS OR ATTRIBUTES
        protected int Id;

        protected string FirstName;
        protected string LastName;

        protected string Address;
        protected string City;

        protected string Email; // meglio mettere una classe email per ottenere la validazione
        protected string Password;  //meglio mettere una proprità asc nascosta
        
        //>>>>>>>>>>>>>>>>>>>><PROPERTIES 
        // DA AGGIUNGERE (GET E SETTER)  
        
        // COSTRUTTORE
        public Customer(string firstname, string LastName)
        {

            this.FirstName = firstname;
            this.LastName = LastName;
        }
        //<<<<<<<<<<<<<<<------------------- 

        // METODI
        public bool Login(string myPassword)
        {
            Console.WriteLine("You are Logged : " + myPassword);
            Console.WriteLine($"Hi you are Logged : {this.FirstName}");
            // da implementare
            return true;
        }

        public bool AddToCart()
        {
            Console.WriteLine("Product added");
            // da implementare
            return true;
        }

        public static void PrintSomething()  // funzione statica , è possibile accederci anche senza istanzialre l'oggetto
        {

        }

    }
}