using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class Customers
    {

        private static int id = 0;

        private List<Customer> myCustomers;//= new List<Customer>(); // è possibile istanziare la lista nel costruttore

        public Customers()  // è possibile istanziare la lista nel costruttore
        {
            this.myCustomers = new List<Customer>(); 
        }

        

        public void Add(Customer _customer)
        {
            myCustomers.Add(_customer);
        }
        public int Count()
        {
            return myCustomers.Count();
        }

        







        public void List()
        {
            throw new System.NotImplementedException();
        }
        public void Cancel()
        {
            throw new System.NotImplementedException();
        }

        public static int  NewId()
        {
            id = ++id;
            return id;
        }
    }
}