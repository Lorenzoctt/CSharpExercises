﻿using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace ECommerce
{
    public class Customer : User
    {

        // >>>> FIELDS OR ATTRIBUTES
        private int age;

        public override bool Login(string myPassword)
        {
            //throw new System.NotImplementedException();

            Console.WriteLine("You are Logged : " + myPassword);
            Console.WriteLine($"Hi you are Logged : {this.FirstName}");
            // da implementare
            return true;
        }

        public override void Logout()
        {       // TODO si sconnette dalla lista  degli utenti collegati (non presente)
            throw new System.NotImplementedException();
        }



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













        //metodi specifici di Customer



        public string GetInfo()
        {    //ritorno 3 valori 
            return this.FirstName + "," + this.LastName + "," + this.Email;
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

        public void RegUser(string firstName, string lastName, string email)  // TODO DA GESTIRE
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            id_user = Customers.NewId();   // TODO  da implementare autogenerazione

        }

        public static int PrintSomething()  // funzione statica , è possibile accederci anche senza istanziare l'oggetto
        {
            return 1000; //ritorno il numero dei clienti
        }



    }
}


