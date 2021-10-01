
using System;
using AcademyWeek2Day5.ADO;
using AcademyWeek2Day5.Entity;
using AcademyWeek2Day5.Entity.Entity;

namespace AcademyWeek2Day5
{
    class Program
    {
        public static BusinessLayer bl = new BusinessLayer(new UtenteRepository());
        static void Main(string[] args)
        {
            //Gioco Mostri vs Eroi

            Console.WriteLine("*********** MOSTRI VS EROI **************");

            Console.WriteLine("Scegli una delle seguente opzioni");
            Console.WriteLine("1. Accedi.");
            Console.WriteLine("2. Registrati.");
           

            //Exit
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");

            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 2)
            {
                Console.Write("\nScelta errata. Inserisci un opzione valida. ");
            }

            switch (scelta)
            {
                case 1:
                    InsertNicknameAndPass();
                    break;
                case 2:
                    Registrazione();  
                    break;

                case 0:
                    Console.WriteLine("Alla prossima partita.");
                    return;
               
            }
        }

        private static void Registrazione()
        {
            Utente utenteProva = new Utente();
            utenteProva = null;
            string nick;
            do
            {
                if (utenteProva != null) Console.WriteLine("Nickname non disponibile");
                Console.WriteLine("Inserisci il tuo nickname");
                 nick = Console.ReadLine();

                utenteProva = bl.ControllaUtente(nick);
            }
            while (utenteProva != null);
               
                Console.WriteLine("Inserisci la tua password");
                string pass = Console.ReadLine();
            Utente newUtente = new Utente();
            newUtente.Nickname = nick;
            newUtente.Password = pass;
                bl.AddUtente(newUtente);
                Console.WriteLine("Registrazione avvenuta con successo");
            ShowMenuNoAdmin();

        }

        internal static void InsertNicknameAndPass()
        {
            Console.WriteLine("Inserisci il tuo nickname");
            string nick = Console.ReadLine();
            Console.WriteLine("Inserisci la tua password");
            string pass = Console.ReadLine();
            Utente u=bl.ControllaUtente(nick);
            if (u == null) Console.WriteLine("Nickname o password errati");
            else if (u.Password == pass) 
            {
                Console.WriteLine("Utente trovato");
                if (u.Admin) ShowMenuAdmin();
                else ShowMenuNoAdmin();
            }
            else Console.WriteLine("Nickname o password errati");
        }

        private static void ShowMenuNoAdmin()
        {
            Console.WriteLine("********* Menù Gioco *********");
            Console.WriteLine("Scegli una delle seguente opzioni");
            Console.WriteLine("1. Gioca.");
            Console.WriteLine("2. Crea nuovo eroe.");
            Console.WriteLine("3. Elimina eroe.");


            //Exit
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");

            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 2)
            {
                Console.Write("\nScelta errata. Inserisci un opzione valida. ");
            }

            switch (scelta)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;


                case 0:
                    return;

            }
        }

        private static void ShowMenuAdmin()
        {
            Console.WriteLine("********* Menù Admin Gioco *********");
            Console.WriteLine("Scegli una delle seguente opzioni");
            Console.WriteLine("1. Gioca.");
            Console.WriteLine("2. Crea nuovo eroe.");
            Console.WriteLine("3. Elimina eroe.");
            Console.WriteLine("4. Crea nuovo mostro.");
            Console.WriteLine("5. Mostra classifica globale.");

            //Exit
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");

            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 2)
            {
                Console.Write("\nScelta errata. Inserisci un opzione valida. ");
            }

            switch (scelta)
            {
                case 1:
                    
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                

                case 0:
                    return;

            }

        }
    }
}
