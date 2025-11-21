// Programm küsib kasutajalt ostusummat ja ütleb, millist allahindlust ta saab.



Console.WriteLine("Sisesta ostusumma");  // ()           -> sulupaar mis omab funktsiooni tööks vajalikku infot
// .            -> näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit
// Palub kasutajal sisestada summa
// ;            -> kõik koodilaused lõppevad komakooloniga, mis tähistavad lause lõppu
// "Console"    -> on moodul C# mida me adresserime, Console aitab teha tegevusi käsureal

// "WriteLine"  -> Funktsioon mida me parasjagu kasutame.



double ostusumma = double.Parse(Console.ReadLine());
// 
// =            -> üksik võrdusmärk omistab muutuja sisse vastava väärtuse mis asub

// Loeb sisendi ja teisendab arvuks

// double on 64-bitine komakohaga arv



if (ostusumma > 100) // Kontrollib, kas summa on suurem kui 100                     
{                    // {}           -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või
    //                 funktsiooni kirjeldust
    //kaitstud sõna "if" kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb
    Console.WriteLine("Saad 20% allahindlust");
}
else if (ostusumma > 50) // Kontrollib, kas summa on 51 kuni 100
{                        //kaitstud sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
    Console.WriteLine("Saad 10% allahindlust");
}
else if (ostusumma > 20) // Kontrollib, kas summa on 21 kuni 50
{
    Console.WriteLine("Saad 5% allahindlust");
}
else if (ostusumma > 0) // Kontrollib, kas summa on 1 kuni 20
{
    Console.WriteLine("Allahindlust ei saa");
}
else // Kui summa on 0 või negatiivne
{    //kaitstud sõna "else" kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if", ning mille koodiploki sisu
    Console.WriteLine("Sisestatud on vigane arv");
}



// Toimimine: programm küsib ostusummat, määrab vahemiku ja kuvab sobiva allahindluse või veateate.