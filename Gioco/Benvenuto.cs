namespace Gioco;


public class benvenuto
{
    static public int Benv()
    {
        Console.WriteLine("Benvenuto nel Gioco.");
        Console.WriteLine("Premi \"s\" per iniziare, \"q\" per uscire");
        string start;
        
        while (true)
        {
            start = Console.ReadLine();
            if (start == "q" || start == "s")
            {
                break;
            }
            else
            {
                Console.WriteLine("\"Premi \"s\" per iniziare, \"q\" per uscire\"");
            }
        }

        if (start == "q")
        {
            Console.WriteLine("Arrivederci");
            return 0;
        }
        /*Adesso facciamo la parte dove ti trovi in una stanza con un visore sul tavolo
         * Lo vuoi indossare? Si --> Scegli personaggio No --> Crepi
         * 
         */
        List<string> Personaggi= new List<string>() { "Ladro", "Mago", "Guerriero" };
        List<string> Statistiche= new List<string>() { "HP: 60\nAgiità: 90\nForza: 70\nIntelligenza: 90", "HP : 70\nAgilità: 60\nForza: 60\nIntelligenza: 80", "HP: 150\nAgilità: 50\nForza: 90\nIntelligenza: 40" };
        
        Console.Write("Ottimo, ora ");
        string scelta;
        int scelt = 0;
        while (true)
        {
            Console.WriteLine("scegli un personaggio. Ogni personaggio ha diverse statistiche.");
            Console.WriteLine("Premi 1 per essere un Ladro\nPremi 2 per essere un Mago\nPremi 3 per essere un Guerriero");
            scelta = Console.ReadLine();
            try
            {
                
                scelt = int.Parse(scelta);

            }
            catch(Exception)
            {
                Console.WriteLine("Devi inserire un numero.");
            }

            if (scelt > 0 && scelt < 4)
            {
                Console.WriteLine($"Hai scelto {Personaggi[scelt-1]} Ha queste statistiche:\n{Statistiche[scelt-1]}");
                Console.WriteLine("Confermi la scelta?\ns per confermare, n per scegliere un altro personaggio");
                string conf;
                while (true)
                {
                    conf = Console.ReadLine();
                    if (conf == "s")
                    {
                        return scelt;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Devi scegliere un personaggio");
                Console.WriteLine("Premi 1 per essere un Ladro\nPremi 2 per essere un Mago\nPremi 3 per essere un guerriero");
                
            }
        }
    }
}
    
    