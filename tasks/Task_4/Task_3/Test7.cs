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
    public class Test7
    {
        [Test]
        public void VornameVorhanden()
        {
            Assert.Catch(() =>
            {
                var x = new ss("", "B");
            }

                );
            
            

        }

    }
}

