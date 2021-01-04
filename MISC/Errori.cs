using System;

namespace NamespaceErrori
{

    class ClassErrori
    {

        public static void MainPrg()  // UTILIZZO InnerException
        {

            try
            {
                // Altre istruzioni ...
                Funzione1();
                // Altre istruzioni ...
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Message: " + ex.InnerException.Message);
                }
            }
        }

        public static void Funzione1()
        {
            try
            {
                int i = 0;
                i = 10 / i;
            }
            catch (Exception ex)
            {
                Console.WriteLine("start invocazione errore");
                //   invocazione errore
                throw new Exception("Errore nella Funzione1", ex);   // aggiungo la funzione e passo l'eccezione originale 
            }
        }




    }
}