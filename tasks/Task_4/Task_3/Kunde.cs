﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using Task_4;

namespace Task_4
{
    public class ss : IKunde
    {
        private int m_kundennummer;
        private string m_vorname;
        private string m_nachname;
        private DateTime m_geb_datum;
        private string pfad = @"C:\Users\user\Desktop\Task2.txt";


        public ss(string newVorname, string newNachname)
        {

            if (newVorname == "") throw new ArgumentOutOfRangeException("Vorname muss vorhanden sein");
            if (newNachname == "") throw new ArgumentOutOfRangeException("Nachname muss vorhanden sein");

            if (File.Exists(pfad))
            {
                m_kundennummer = int.Parse(System.IO.File.ReadAllText(pfad)) + 1;
                System.IO.File.WriteAllText(pfad, m_kundennummer.ToString());
            }
            else
            {
                File.WriteAllText(pfad, "1");
                m_kundennummer = 1;
            }

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

        //----under construction --------------
        public void Print()
        {
            Console.WriteLine("Jetzt passiert was !");
        }

        #region IKundenname

        public virtual void PrintKundeData()
        {
            Console.Out.WriteLine("{0} {1}", Vorname, Nachname);
        }
        #endregion


    }
}
