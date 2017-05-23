using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;

using System.IO;

namespace Task_4
{
    [TestFixture]
    public class Test4
    {
        [Test]
        public void IchFehle()
        {
            string newTick = File.ReadAllText(@"C:\Users\user\Desktop\Kunde - Kopie.json");
            Kunde s = JsonConvert.DeserializeObject<Kunde>(newTick);

            Assert.AreNotEqual(s.Nachname,"Pöll");
        }

    }
}
