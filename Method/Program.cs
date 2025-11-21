using System.Dynamic;
using System.Threading.Channels;

internal class Program
{
    private static void main(string[] args)
    {
        NewMessage();
        List<string> ostunimekiri = new List<string>();
        Console.WriteLine("Sisesta oma tänane poesläigunimekiri");
        string kasutajaSisestus = "";
        GetUserInput(kasutajaSisestus, ostunimekiri);
        foreach (var söök in ostunimekiri)
        {
            Console.WriteLine($" -*- {söök}");
        }
        GetUserInput(kasutajaSisestus, ostunimekiri);

    }
        
        static List <string> GetUserInput(string kasutajaSisestus, List<string> ostunimekiri)
        {
            while (kasutajaSisestus != "rohkem pole")
            {
                  Console.WriteLine("kirjuta ükshaaval, sisesta järgmine ost:\nkui rohkem ei ole midagi lisada, siis ütle \"rohke, pole\"");
                  kasutajaSisestus = Console.ReadLine();
                  if (kasutajaSisestus != "" || kasutajaSisestus != "rohkem pole")
                  {
                       ostunimekiri.Add(kasutajaSisestus);
                  }
                  else if (kasutajaSisestus == "rohkem pole")
                  {
                     kasutajaSisestus = "";
                  } 
            }
                  Console.WriteLine("see sinu mimekiri");
                  return ostunimekiri;
        }
    static void NewMessage()
    {
        Console.WriteLine("this is message");
    }
}