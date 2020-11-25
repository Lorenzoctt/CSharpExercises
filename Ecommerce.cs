using System;

namespace ECommerce
{
    class Customer
    {

        // Visibilità -- valore di ritorno  -- Nomemetodo

        protected int Id;

        protected string Name;
        protected string LastName;

        protected string Address;
        protected string City;

        protected string Email; // meglio mettere una classe email per ottenere la validazione
        protected string Password;  //meglio mettere una proprità asc nascosta
        public bool Login(string myPassword)
        {
            Console.WriteLine("You are Logged");
            // da implementare
            return true;

        }

        public bool AddToCart()
        {
            Console.WriteLine("Product added");
            // da implementare
            return true;

        }

    }
}