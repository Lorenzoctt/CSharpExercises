using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public abstract class User
    {

        protected int id_user;
        protected string FirstName;
        protected String LastName;
        protected int Address;
        protected int Cap;
        protected string City;
        protected string Email; //  meglio mettere una classe email per ottenere la validazione
        protected string Password; // meglio mettere una proprità asc nascosta

        public int Id_user
        {
            get { return id_user; }

        }

        public abstract void Logout();
 

        public abstract bool Login(string myPassword);




    }
}