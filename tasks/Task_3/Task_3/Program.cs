using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using Task_3;


namespace Task_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string temp_vorname, temp_nachname;

            TextInfo ti = new CultureInfo("de-de", false).TextInfo;




            Console.WriteLine("Bitte Vorname eingeben :\n");
            temp_vorname = Console.ReadLine();
            Console.WriteLine("Bitte Nachname eingeben :\n");
            temp_nachname = Console.ReadLine();
            Kunde a = new Kunde(temp_vorname, temp_nachname);


            Console.WriteLine("Hallo " + a.Kundennummer + " " + ti.ToTitleCase(a.Vorname) + " " + ti.ToTitleCase(a.Nachname) + "\n");

            Console.WriteLine("Bitte anderen Nachnamen eingeben :\n");
            a.Nachname = Console.ReadLine();
            Console.WriteLine("Bitte Geburtsdatum eingeben :\n");
            a.GebDatum = DateTime.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine(ti.ToTitleCase(a.Vorname) + " " + ti.ToTitleCase(a.Nachname) + "\n" + "Geb.Datum : " + a.GebDatum.Day + "." + a.GebDatum.Month + "." + a.GebDatum.Year + "\n" + "Kundennummer : " + a.Kundennummer + "\n");
            Console.WriteLine("--------------------------------------------------------\n");

            
            a.Print();
            a.PrintKundeData();
            NochEineKlasse b = new NochEineKlasse();
            b.Print();
        }
    }
}
