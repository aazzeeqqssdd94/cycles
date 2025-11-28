using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random juhuarv = new Random();
            Console.WriteLine("kas sa tahad münti visata, või täringust veeretada");
            string kasutajaValik = Console.ReadLine();
            if (kasutajaValik == "münti")
            {
                Console.WriteLine(Münt(juhuarv));
            }
            else if (kasutajaValik == "täringut")
            {
                Console.WriteLine(Täring(juhuarv));
            }
            else
            {
                Console.WriteLine("Ei tea sellist vastust");
            }
            // NewMessage(); ...
        }



        private static int Täring(Random random)
        {
            // tee uus täringuvise ja tagasta juhuarvu abil tulem,us kasutajale
        }

        static string Münt(Random thing)
        {
            int mündivise = thing.Next(1,2);
            if (mündivise == 1)
            {
                return "kull";
            }
            else
            {
                return "kiri";
            }
            return "serv";
        }

    }

       


}
