using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ECommerce
{
    class Users
    {
        private static List<User> UsersList = new List<User>();
        private const string usersC_Path = @"C:\Users\Lorenzo\Desktop\EserciziC#\CSharpExercises\Data\Users_C.csv";

        public Users() { }

        public void WriteToFileCname()  // salvo la lista nel file 
        {
            string tempData = "";
            List<string> tempUsersList = GetC();
     


            foreach (string item in tempUsersList)
            {
                tempData = tempData + item + Environment.NewLine;
            }

            File.WriteAllText(usersC_Path, tempData); 
        }


        public void AddToList(User utente)
        {
            UsersList.Add(utente);
        }

        private  List<string> GetC()
        {
            IEnumerable<string> query =
             from elemento in UsersList
             where elemento.Name[0] == 'C'   //ho dovuto mettere public il campo : Gravità	Codice	Descrizione	Progetto	File	Riga	Stato eliminazione
                                             //Errore CS0122  'User.Name' non è accessibile a causa del livello di protezione CSharpExercises C: \Users\Lorenzo\Desktop\EserciziC#\CSharpExercises\Classes\Users.cs	44	Attivo


             select elemento.Name;

            return query.ToList();  // ritorna la  query

        }




    }
}
