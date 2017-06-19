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
    public class Test5
    {
        [Test]
        public void VornamePasst()
        {
            var x = new ss("A", "B");
            Assert.IsTrue(x.Vorname == "A");
            
        }

    }
}

