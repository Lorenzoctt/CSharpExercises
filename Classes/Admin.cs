using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce
{
    public class Admin: Customer
    {
        private bool administrator;

        public void SetAdministrator(bool come)
        {
            administrator = come;
        }
    }
}