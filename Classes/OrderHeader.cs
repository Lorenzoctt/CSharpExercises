using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class OrderHeader
    {
        private int Id_order;

        private DateTime Data;

        private int Id_internalOrder;

        private int Id_User;


        public OrderHeader(int id_user)
        {

            this.Id_User = id_user;
        }
        public void Create(Customer _customer)  //TODO
        {



            this.Id_order = 1001;// da implememtare in automatico
            this.Data = DateTime.Now;
            this.Id_internalOrder = 1;  // da implememtare in automatico

        }

        public void List()
        {
            throw new System.NotImplementedException();
        }

        public void Cancel()
        {
            throw new System.NotImplementedException();
        }
    }
}