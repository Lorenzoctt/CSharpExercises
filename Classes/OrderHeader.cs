using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class OrderHeader
    {
#pragma warning disable CS0414 // Il campo 'OrderHeader.Id_order' è assegnato, ma il suo valore non viene mai usato
        private int Id_order;
#pragma warning restore CS0414 // Il campo 'OrderHeader.Id_order' è assegnato, ma il suo valore non viene mai usato
        private DateTime Data;
#pragma warning disable CS0414 // Il campo 'OrderHeader.Id_internalOrder' è assegnato, ma il suo valore non viene mai usato
        private int Id_internalOrder;
#pragma warning restore CS0414 // Il campo 'OrderHeader.Id_internalOrder' è assegnato, ma il suo valore non viene mai usato
        private int Id_User;


        public OrderHeader(int id_user)
        {

            this.Id_User = id_user;
        }
        public void Create(Customer _customer)
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