using System.ComponentModel.Design;

namespace SõneÜlesanne2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> kasutajad = new List<List<string>>();
            kasutajad.Add(new List<string>() { "user1", "password1" });
            kasutajad.Add(new List<string>() { "user2", "passwrod2" });

            string kasutajanimi = "";
            Console.WriteLine("Palun sisesta oma kasutajanimi");
            kasutajanimi = Console.ReadLine();
            bool doesExist = false;
            string õigeparool = "";

            foreach (var user in kasutajad)
            {
                if (user[0] == kasutajanimi)
                {
                    doesExist = true;
                    õigeparool = user[1];
                } 
            }
            if (doesExist == true)
            {
                string sisestus = "";
                do
                {
                    Console.WriteLine("palun sisesta oma parool:");
                    sisestus = Console.ReadLine();
                } while (sisestus != õigeparool);
                //
                Console.WriteLine($"Tere tulemast {kasutajanimi}");
            }
            else
            {
                Console.WriteLine("kasutaja ei eksisteeri");
            }
        }   
    }
}
