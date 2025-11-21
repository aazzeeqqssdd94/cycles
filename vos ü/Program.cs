Console.WriteLine("Tere külaline, palun registreeri ennast! mis on sinu nimi?");
string kasutajaNimi = Console.ReadLine();
if (kasutajaNimi == "")
{
    Console.WriteLine("Ok, kuna sa oma nime ei kirjutanud, annan sulle ise nime - nimetuKasutaja");
    kasutajaNimi = "nimetuKasutaja";
}    
Console.WriteLine("Palun sisesta ka oma kasutaja jaoks parool:");
int kasutajaparool = int.Parse(Console.ReadLine());
if (kasutajaparool == 1234)
{
    Console.WriteLine("Seda ei saa paroolina kasutada, määrasin sulle ise parooli 'A43Ü'");
}
Console.WriteLine($"Aitäh {kasutajaNimi}, olete registreeritud");