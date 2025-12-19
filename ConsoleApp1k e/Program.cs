using System.Threading.Channels;

namespace ConsoleApp1k_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            tervitus();

            //2
            kokkuarvutatavat();

            //3
            nimi();

            //4
            kiir();
        }

        //1
        public static void tervitus()
        {
            Console.WriteLine("Tere!");
        }

        //2
        public static void kokkuarvutatavat()
        {
            List<int> list = new List<int>();
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            list.Add(number);

            Console.WriteLine($"you chose {" "} {list[0]}");
            
            

        }
        
        //3
        public static void nimi()
        {
            string nimi;
            Console.WriteLine("kirjuta oma nimi");
            while (true)
            {
                nimi = Console.ReadLine();
                if (nimi == "")
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    tervitus();  Console.WriteLine(nimi);
                    break;
                }
            }
            //pikk
            nimi.Count();
            Console.WriteLine($"sinu nimi pikk on {nimi.Count()}");
        }

        //4
        public static void kiir()
        {
            Console.WriteLine("kui kiiresti ta läks?");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed > 0 && speed < 19)
            {
                Console.WriteLine("bad speed");
            }
            else if (speed > 20 && speed < 39)
            {
                Console.WriteLine("aeglane");
            }
            else if (speed > 40 && speed < 59)
            {
                Console.WriteLine("normaalne");
            }
            else if (speed > 60 && speed <= 100)
            {
                Console.WriteLine("ületasid kiirust");
            }
            else
            {
                Console.WriteLine("nice");
            }
        }
    }
}
