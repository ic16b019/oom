using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft;
using System.IO;

namespace Task_4
{
    [TestFixture]
    public class Test3
    {
        [Test]
        public void VornamenSindUngleich()
        {
            var t1 = new ss("Karli","Burli");
            var t2 = new ss("Hansi", "Burli");

            Assert.AreNotEqual(t1.Vorname, t2.Vorname);
        }

    }
}
