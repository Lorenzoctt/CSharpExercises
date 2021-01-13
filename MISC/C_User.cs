using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ECommerce
{
    class C_User
    {

        private int _age;
        private string _name;
       // protected string cosa;

        //      protected Name {get; set }


        private int Age
        {
            get
            { return _age; }

            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
                else
                    throw new InvalidOperationException("L'eta inserita non è validas");
            }
        }



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public C_User() { }
        public C_User(string nome, int eta)
        {
            this._name = nome;
            this.Age = eta;
        }



    }  // end user


}  //end ECommerce








