
using System.ComponentModel;

namespace Gioco
{
    internal class Program

    {





        public static void Main(string[] args)
        {

            string c = "a"; //comando

            Console.WriteLine("!! -_THE GAME_- !!");
            int Scelta = benvenuto.Benv();

            Personaggio_Class player = null;
            //object player = ClassInit(Scelta);
            if (Scelta == 1)
            {
                player = new Ladro();

            }
            else if (Scelta == 2)
            {
                player = new Mago();
            }
            else
            {
                player = new Guerriero();

            }
            /*Se sei uno o l'altro inizia in modo diverso, ma nonostanza l'inizio diverso tutti finiscono nel punto di inizio del game
             * 
             */


            //controllo inserimento nome
            do
            {
                Console.WriteLine("Inserire nome giocatore: ");
                player.nome = Console.ReadLine();
            } while (string.IsNullOrEmpty(player.nome));

            //inserimento comando
            Console.WriteLine("inserisci comando:");
            c = Console.ReadLine();

            //   while(c == "stats")
            if (c == "stats")
            {
                Console.WriteLine(player.ToString());
            }
            else
            {
                if (c == "help")
                {
                    Console.WriteLine("-_-_-COMANDI-_-_-");
                    Console.WriteLine("stats --> per vedere le statistiche");
                    Console.WriteLine("zaino --> per vedere cosa hai nello zaino");
                    Console.WriteLine("y --> yes");
                    Console.WriteLine("n --> no");

                    Console.WriteLine();
                    Console.WriteLine("inserisci comando:");
                    c = Console.ReadLine();
                }
            }

            Console.WriteLine();
        }
    }
}
//Console.WriteLine("ciao " + player.nome + " , mi hanno detto che ti piace perdere tempo!, benvenuto in questo mondo , dove tutto può accadere soprattutto quello che non ti aspetti 'punto esclamativo'. ");

