using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ECommerce
{
    class User
    {

        private int _age;
        private string Name;



        public int Age
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


        public User(string nome, int eta)
        {
            this.Name = nome;
            this.Age = eta;
        }






        private static List<User> UsersList = new List<User>();
        private const string usersC_Path = @"C:\Users\Lorenzo\Desktop\EserciziC#\CSharpExercises\Data\Users_C.csv";
        public void WriteToFileCname()  // salvo la lista nel file 
        {
            string tempData = "";
            List<string> tempUsersList = GetC();



            foreach (string item in tempUsersList)
            {
                tempData = tempData + item + Environment.NewLine;
            }

            File.WriteAllText(usersC_Path, tempData); //   SOSTITUISCE SEMPRE System.UnauthorizedAccessException su estensioni conosciute

            //File.AppendAllText(ArticlePath, tempData);
        }




        private static List<string> GetC()
        {
            IEnumerable<string> query =
             from fieldtmp in UsersList
             where fieldtmp.Name[0] == 'C'

             select fieldtmp.Name;

            return query.ToList();  // ritorna la  query

        }

        public void AddToList(User utente)
        {
            UsersList.Add(utente);
        }


    }
}  //end ECommerce








