
string[] konsoolid = { "playstation 1", "xbox360", "valve steam machine" };

//List<string> mängud = new List<string>();

////foreach (var konsool in konsoolid)
////{
////    Console.WriteLine(konsool);
////}

////for (int i = 0; i < konsoolid.Length; i++)
////{
////    Console.WriteLine(konsoolid[i]);
////}

//string currentEntry = ""; //ajutine muutuja mis hoiab tekstiitüüp andmeid, hetkel tühi

//while (currentEntry == "") //while tsükkel mis toiib niikaua kuni currententry on tühi
//{
//    Console.WriteLine("Sisesta mäng või kirjuta ei taha kui soovid esitust lõpetada");
//    //esitamwe kasutajale sõnumi
//    currentEntry = Console.ReadLine();
//    //paname ajutisse muutujasse info kasutaja kirjutas "ei taha", teeme ifi sisu
//    if (currentEntry =="ei taha")
//    {
//        break; //break katkestab kogu tsükli, peatades sisestamise
//    }
//    //mängud[i] = currentEntry;
//    mängud.Add(currentEntry); //lisame loendile osta kasutaja sisestatud info
//    currentEntry = ""; //omistame nuutujasse currententry uuesti tühi sisestuse, et tsüklkel
//}

//Console.WriteLine("n\n\n");

//foreach (var mäng in mängud)
//{ 
//    Console.WriteLine(mäng);
//}

Console.WriteLine("Mis on su lemmikvärv? sisesta palun ükshaaval\nKui rohkem värve ei ole, kirjuta \"rohkem pole\"");
List<string> kasutajaVärvid = new List<string>();

string sisestus = "";
do
{
    Console.WriteLine("sisesta 1 värv korraga:");
    sisestus = Console.ReadLine();

    if (sisestus != "rohkem pole")
    {
        kasutajaVärvid.Add(sisestus);
    }
}
while (sisestus != "rohkem pole");

foreach (var värv in kasutajaVärvid)
{
    switch (värv)
    {
        // punane, oranz, kollane, roheline, helesinie, tumeroheline, tumesinine, lilla,
        // roosa, pruun, must, valge, hall, värvi-ei-tunta
        // roosa oranz - neid värve ei ole, tagast sõnum mis on värevisepetsiifiline
        case "punane":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- p u n a n e -*-*-");
            break;
        /* LISAGE ISESEISVALT KÕIKIDE MUUDE VÄRVIDE CASED */
        case "oranž":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Oranz pole saadavalt");
            break;
        
        case "kollane":
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- k o l l a n e -*-*-");
            break;

        case "roheline":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- r o h e l i n e -*-*-");
            break;

        case "helesine":
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- h e l e s i n e -*-*-");
            break;

        case "tumeroheline":
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- t u m e r o h e l i n e-*-*-");
            break;

        case "tumesinine":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- t u m e s i n i n e -*-*-");
            break;

        case "lilla":
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- l i l l a -*-*-");
            break;

        case "roosa":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- pole Värvi -*-*-");
            break;

        case "pruun":
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- p r u u n -*-*-");
            break;

        case "must":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- m u s t -*-*-");
            break;

        case "valge":
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- v a l g e -*-*-");
            break;

        case "hall":
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- p r u u n -*-*-");
            break;

        default:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Ei tunne sellist värvi{värv}");
            break;
    }
}