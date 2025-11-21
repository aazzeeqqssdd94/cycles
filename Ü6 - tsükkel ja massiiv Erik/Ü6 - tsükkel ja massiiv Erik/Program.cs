// kirjuta programm mis küsib kasutajalt tema nime ja parooli

// kui parool on vale, anna nimeline teavitus

// kui nimi on vale, ütle et isik pole registreerunud

// tekita massiiv suurusega 3

// kui mõtlemad on õiged, siis while tsüklis küsi kasutajalt tema 3 lemmikloomanime

// kuva talle sisestuste arv (mitu ta sisestas)

// ning küsi milline on ta lemmikuim

// tagasta kasutajale lause koos selle lemmiknimega adresseerides seda järjendist[]

using System;

class Program
{
    static void Main()
    {
        string correctName = "User";      // õige nimi
        string correctPassword = "1234";  // õige parool

        string[] inputs = new string[3];  // lemmikloomade nimede massiiv
        int attempts = 0;

        Console.WriteLine("Sisesta nimi:");
        string name = Console.ReadLine();

        Console.WriteLine("Sisesta parool:");
        string password = Console.ReadLine();

        // kontrollime nime ja parooli while tsükliga ilma if-ita
        while ((name != correctName ? 1 : 0) + (password != correctPassword ? 1 : 0) > 0)
        {
            Console.WriteLine((name != correctName ? "Kasutaja pole registreeritud" : "") +
                              (password != correctPassword ? $"{name}, vale parool" : ""));

            Console.WriteLine("Proovi uuesti.");
            Console.WriteLine("Sisesta nimi:");
            name = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            password = Console.ReadLine();
        }

        // nimi ja parool on õiged, palume sisestada 3 lemmiklooma nime
        int index = 0;
        while (index < 3)
        {
            Console.WriteLine($"Sisesta lemmiklooma {index + 1} nimi:");
            inputs[index] = Console.ReadLine();
            index++;
        }

        Console.WriteLine($"Sa sisestasid {index} lemmiklooma.");

        int favIndex = -1;
        do
        {
            Console.WriteLine("Milline on su lemmikloom neist? (sisesta number 1-3)");
            bool success = int.TryParse(Console.ReadLine(), out favIndex);
            favIndex--; // massiiv algab nullist
        } while (favIndex < 0 || favIndex >= 3);

        Console.WriteLine($"Sinu kõige lemmikum loom on {inputs[favIndex]}!");
    }
}
