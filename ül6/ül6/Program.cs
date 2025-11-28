using System.Numerics;

namespace ül6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kasutajanii
            Console.WriteLine("palun sisesta oma kasutajanimi:");
            do 
            {
                string kasutajaNimi = Console.ReadLine();
                if (kasutajaNimi == "User1")
                {
                    Console.WriteLine($"sinu kasutajanimi on {kasutajaNimi}");
                    break;                    
                }
                else
                {
                    Console.WriteLine("te pole registreeritud");
                    continue;
                }
            }
            while (true);

            //Parool
            Console.WriteLine("palun sisessta oma parool");
            do
            {
                int parool = int.Parse(Console.ReadLine());
                if (parool == 4321)
                {
                    Console.WriteLine("õige parool");
                    break;
                }
                else
                {
                    Console.WriteLine("vale parool");
                    continue;
                }
            }
            while (true);

            //3 lemmikloomanime            
          string [] loom = new string[3];
            Console.WriteLine("sisestage 3 lemmiklooma nime");
            Console.WriteLine("Sisestage esimene nimi");
            loom[0] = Console.ReadLine();
            Console.WriteLine("Sisestage teine nimi");
            loom[1] = Console.ReadLine();
            Console.WriteLine("Sisestage kolmas nimi");
            loom[2] = Console.ReadLine();
            Console.WriteLine($"1.{loom[0]}, 2.{loom[1]}, 3.{loom[2]}");

            Console.WriteLine("valige lemmikloom (1-3)");
            int valik = 0;
            do
            {
                valik = int.Parse(Console.ReadLine());
                if (valik == 1)
                {
                    Console.WriteLine($"sina valisid on {loom[0]}");
                    break;
                }
                else if (valik == 2)
                {
                    Console.WriteLine($"sina valisid on {loom[1]}");
                    break; 
                }
                else if (valik == 3)
                {
                    Console.WriteLine($"sina valisid on {loom[2]}");
                    break;
                }
                else
                {
                    Console.WriteLine("valige 1, 2 või 3");
                    
                }

            }
            while(valik != 1 || valik != 2 || valik != 3 || valik == 0);




        }
    }
}
