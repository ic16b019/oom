using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3;

namespace Task_3 
{
    class NochEineKlasse : IKunde
    {
        private string m_vorname;
        private string m_nachname;
        public NochEineKlasse()
        {
            m_vorname = "DONALD";
            m_nachname = "TRUMP";
        }
            
        public string NochEinVorname
        {
            get { return m_vorname; }
        }
        public string NochEinNachname
        {
            get { return m_nachname; }
        }
        //----under construction --------------
        public void Print()
        {
            Console.WriteLine("Jetzt passiert schon wieder was !");
            Console.Out.WriteLine("{0} {1}", m_vorname, m_nachname);
        }
    }
  



}
