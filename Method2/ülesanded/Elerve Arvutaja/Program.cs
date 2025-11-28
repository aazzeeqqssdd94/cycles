namespace Elerve_Arvutaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nimi
            string kasutajaNimi = "";
            while (kasutajaNimi == "")
            {
                Console.WriteLine("Tere, sisesta om nimi");
                kasutajaNimi = Console.ReadLine();
            }

            //küsi kasutajalt tema tulisid, niikaua kuni rohkempole
            string sisestus = "";
            List<float> tulud = new List<float>();
            do
            {
                Console.WriteLine("sisesta om tulud *ÜKSHAAVAL* - järgmine tulu:");
                sisestus = Console.ReadLine();

                float conversion = float.Parse(sisestus);
                tulud.Add(conversion);

            } while (sisestus != "rohkem pole");
            Console.WriteLine(sisestus);

            //siis
            //string sisestus = "";
            //List<float> tulud = v

            //    //
            if (sisestus == "")
                arvutakokku(tulud);
            //    //
            //    //
            //    //
            //    //
            //    //
            //    //



        }

        private static void arvutakokku(List<float> tulud)
        {
            float kokku = 0;
            for (int i = 0; i < tulud.Count; i++)
            {
                kokku += tulud[i];
            }
        }
    }
}
