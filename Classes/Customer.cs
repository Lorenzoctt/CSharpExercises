using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace CSharpExercises
{
    public class Customer
    {

        // >>>> FIELDS OR ATTRIBUTES

        private int Id_user;
        private string FirstName;
        private String LastName;
        private int Address;
        private int Cap;
        private string City;
        private string Email; //  meglio mettere una classe email per ottenere la validazione
        private string Password; // meglio mettere una proprità asc nascosta


        // COSTRUTTORE
        public Customer(string firstname, string LastName)
        {
            this.FirstName = firstname;
            this.LastName = LastName;
        }


        //Aggiungi alla classe Customer un costruttore per assegnare nome, cognome ed email ai campi della classe
        public Customer(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
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

        public void RegUser()
        {
            throw new System.NotImplementedException();

        }


        public bool AddToCart()
        {
            Console.WriteLine("Product added");
            // da implementare
            return true;
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
}


