using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Veehoidla_Erik
{
    public class MeetodiKodutöö
    {
        public MeetodiKodutöö()
        {
            //1. ülesanne
            // kirjuta meetod mis tervitab kasutajat
            // kirjuta meetod mis ütleb talle headaega
            // meetodeid kasutatakse programmis, mis apelsin ananass, kus kõigepealt tsüklis kasutajalt tema nime
            // nimi salvestatakse muutuja antakse kaasa meetoditele. meetodid ise midagi ei tagasta.


            //2. ülesanne
            //kirjuta meetod, mis joonistab käsureale ruudu, võtab parameetrik kas täisarvu, (x ja y) ja konsoolivärvi.
            //kirjuta teine meetod, mis vahetab konsooli värvi ja võtab parameetriks kasutaja sisestuse
            // meetodeid kasutatakse programmsi, kus, abrakadabra, küsitakse kasutajalt tema lemmikvärvi, teie meetodi abil
            // teise meetodi tulemus hoitakse muutujas, ning see antakse kaasa eimesele meetodile, mis joonistab ruud aga õige värviga

            // varasemate ülesannete osi, saab siin taaskasutada.
        }
        //1. Ülesanne
        private static void tere()
        {
            Console.WriteLine("tere");
        }
        private void headaega()
        {
            Console.WriteLine("headaega");
        }
        private void nimi()
        {
            Console.WriteLine("Palun kirjuta teie kasutajanimi");
            while (true)
            {
                string kasutajanimi = Console.ReadLine();
                if (kasutajanimi == "")
                {
                    Console.WriteLine("proovi uuesti");
                }
                else
                {
                    Console.WriteLine($"tere {kasutajanimi}");
                        break;
                }
            }
        }
        //2. ülesanne
        private static void xy()
        {
            Console.WriteLine("kirjuta oma x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kirjuta oma y");
            int y = Convert.ToInt32(Console.ReadLine());
            string x1 = "-";
            string y1 = "|";
            for (int i = 0; i < x1.Length; i++)
            {
                Console.WriteLine(x1);
            }
            
        }
    }
}
