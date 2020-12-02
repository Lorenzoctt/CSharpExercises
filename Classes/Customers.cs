using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class Customers
    {


       private List<Customer> myCustomers = new List<Customer>();

        public void List()
        {
            throw new System.NotImplementedException();
        }
       
        public void Add(Customer _customer)
        {
            myCustomers.Add(_customer);
        }

        public void Cancel()
        {
            throw new System.NotImplementedException();
        }
        public int Count()
        {
            return myCustomers.Count();
        }
    }
}