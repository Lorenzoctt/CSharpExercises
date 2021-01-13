using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class Admin: User
    {
        private bool administrator;

        public void SetAdministrator(bool come)
        {
            administrator = come;
        }


        public override bool Login(string myPassword)
        {
            //throw new System.NotImplementedException();

            Console.WriteLine("You are Logged : " + myPassword);
            Console.WriteLine($"Hi you are Logged : {this.FirstName}");
            // da implementare
            return true;
        }

        public override void Logout()
        {       // TODO si sconnette dalla lista  degli amministrtori collegati (non presente)
            throw new System.NotImplementedException();
        }

        public void AggiungiUser(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
             // TODO  da implementare    aggiunta amministratori

        }
    }
}