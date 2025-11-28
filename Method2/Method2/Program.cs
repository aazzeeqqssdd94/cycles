
namespace Method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Tervitus();
            string kasutajaNimi = "";
            Tervitus();
            kasutajaNimi = KasutajabimeKüsimine(kasutajaNimi);
            float eelarve = 0.00f;
            bool KasKasutajaNõustub = false;
            Tervitus();
            KasKasutajaNõustub = NõusolekuKüsimine(kasutajaNimi, eelarve, KasKasutajaNõustub);
            //küsi kasutaja tema nime (tsüklis)
            //küsi kasutaja tema tulusid, nikaua kuni rohkem pole -
            //siis küsi kasutajalt tema kulusid, ka niikaua kuni rohkem pole.
            //hoia andmeid list tüüpi muutujas, andmed ise peavad olEeema 
        }

        private static void Tervitus()
        {
            throw new NotImplementedException();
        }

        private static bool NõusolekuKüsimine(string kasutajaNimi, float eelarve, bool KasKasutajaNõustub)
        {
            while (KasKasutajaNõustub == false)
            {
                Console.WriteLine($"{kasutajaNimi},kas see on sinu õige eelarve: {eelarve}");
                Console.WriteLine("Vasta kas jah või ei");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    KasKasutajaNõustub = true;
                }
                else
                {
                    KasKasutajaNõustub = false;
                }
            }

            return KasKasutajaNõustub;
        }

        private static string KasutajabimeKüsimine(string kasutajaNimi)
        {
            while (kasutajaNimi == "")
            {
                Console.WriteLine("TERRE, palun sisesta oma kasutajaNimi");
                kasutajaNimi = Console.ReadLine();

            }
            Console.WriteLine("Mis on sinu nädalane eelarve?");
            return kasutajaNimi;
        }
    }
}
