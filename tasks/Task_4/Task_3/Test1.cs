using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task_4
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void IstRichtig()
        {
            Assert.IsTrue(1==1);
        }

    }
}
