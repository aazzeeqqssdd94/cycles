string kasutajaNimi = "";
do
{
    Console.WriteLine("Palin sisesta oma kasutajanimi: ");
    kasutajaNimi = Console.ReadLine();
}  while (kasutajaNimi != "user1");
if (kasutajaNimi == "user1")
{
    int ruuduSuurus = 0;
    do
    {
        Console.WriteLine("kui suurt ruutus saada tahad?");
        ruuduSuurus = int.Parse(Console.ReadLine());
    } while (ruuduSuurus < 0 ||  ruuduSuurus > 20);

    char reaKujund = '▓';
    string ÜksidRida = "";
    int tsükliMuutuja = ruuduSuurus;

    do
    {
        ÜksidRida = ÜksidRida + "_" + reaKujund;
        tsükliMuutuja = tsükliMuutuja - 1;
    } while (tsükliMuutuja != 0);

    tsükliMuutuja = ruuduSuurus;

    do
    {
        Console.WriteLine(ÜksidRida);
        tsükliMuutuja -= 1;
    } while (tsükliMuutuja != 0);

    Console.WriteLine($"Paluń, siin in sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");

}


