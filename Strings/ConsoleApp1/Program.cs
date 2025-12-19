using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("kui vana sa oled");
            int vana = Convert.ToInt32(Console.ReadLine());
            do
            {

                if (vana == 0)
                {
                    vana = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("error");                    
                }
                else
                {
                    Console.WriteLine($"sinu vansu on {vana}");
                    break;
                }
            } while (true);

            //2

            Console.WriteLine("kirjuta oma aastaarvu");
            int aastaarv;
            while (true)
            {               
                aastaarv = Convert.ToInt32(Console.ReadLine());
                if (aastaarv >= 1 && aastaarv < 2025)
                {
                    Console.WriteLine($"sinu aastaarvu on {aastaarv}");
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("proovin uesti");
                }
            }

            Console.WriteLine("kirjuta oma parool");
            int parool = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (aastaarv >= 1 && aastaarv < 9999)
                {
                    Console.WriteLine($"sinu parool on {parool}");
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("proovin uesti");
                }
            }

            //3
            List<string> puuviljad = new List<string>();
            Console.WriteLine("kui palju gift?");
            int palju = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < palju; i++)
            {
                Console.Write($"{1 + i}.");
                puuviljad.Add(Console.ReadLine());
            }

            Console.WriteLine("your chose is");
            int b = 0;

            
            for (int i = 0; i < palju; i++)
            {
                Console.WriteLine($"{1 + i}. " + puuviljad[b] );
                b++;
            }

            //4
            List<string> masiv = new(5);
            Console.WriteLine("kirjuta oma 5 sõna");
            int viis = 0;
            int sikseven = 1;
            while (viis < 5)
            {
                Console.WriteLine($"kirjuta oma {sikseven} ");
                masiv.Add(Console.ReadLine());
                viis++;
                sikseven++;
            }

            int a = 0;
            int c = 1;

            foreach (var dota in masiv)
            {
                Console.WriteLine($"{c}. {masiv[a]}");
                a++;
                c++;
                

            }

            



        }
    }
}
