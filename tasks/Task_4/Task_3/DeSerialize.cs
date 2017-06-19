using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Task_4;

using Newtonsoft.Json;
using System.IO;

namespace Task_4
{
    class DeSerialize
    {
        
        public static  void test()
        {
            ss test = new ss("Arnold", "Schwarzenegger");
            test.GebDatum = DateTime.Parse("24/12/2000");
            string s = JsonConvert.SerializeObject(test);
            File.WriteAllText(@"C:\Users\user\Desktop\Test.json", s);
            using (StreamReader r = new StreamReader(@"C:\Users\user\Desktop\Test.json"))
            {
                string json = r.ReadToEnd();
            
                dynamic array = JsonConvert.DeserializeObject(json);


                Console.WriteLine("DeSerialize Test \n");
                Console.WriteLine("{0} {1} {2} {3}", array.Kundennummer, array.Nachname, array.Vorname, array.GebDatum);
                
            }
            
        }

    }
}
