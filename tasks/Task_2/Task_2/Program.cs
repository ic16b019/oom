using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;


namespace Task_2
{public class Kunde
    {
        private int m_kundennummer;
        private string m_vorname;
        private string m_nachname;
        private DateTime m_geb_datum;


        public Kunde ( string newVorname, string newNachname)
        {
            
            if (newVorname == "") throw new ArgumentOutOfRangeException("Vorname muss vorhanden sein");
            if (newNachname == "") throw new ArgumentOutOfRangeException("Nachname muss vorhanden sein");
            m_kundennummer = int.Parse(System.IO.File.ReadAllText(@"C:\Users\user\Desktop\Task2.txt")) + 1;
            System.IO.File.WriteAllText(@"C:\Users\user\Desktop\Task2.txt", m_kundennummer.ToString());
            
            m_vorname = newVorname;
            m_nachname = newNachname;
            
        }

        public int Kundennummer
        {
            //set { m_kundennummer = value; }
            get { return m_kundennummer; }
        }
        public string Vorname
        {
            set { m_vorname = value; }
            get { return m_vorname; }
        }
        public string Nachname
        {
            set { m_nachname = value; }
            get { return m_nachname; }
        }
        public DateTime GebDatum
        {
            set { m_geb_datum = value; }
            get { return m_geb_datum; }
        }




    }
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


        }
    }
}
