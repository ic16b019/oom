using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task_4
{
    [TestFixture]
    public class Test2
    {
        [Test]
        public void IstFalsch()
        {
            Assert.IsTrue(1==2);
        }

    }
}
