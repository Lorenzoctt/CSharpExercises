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

        protected string Email;
        protected string Password;
        public bool Login(string myPassword)
        {
             Console.WriteLine("You are Logged");
            // da implementare
            return true;
        }
    }


}