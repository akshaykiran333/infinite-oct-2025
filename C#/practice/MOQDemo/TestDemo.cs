using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQDemo
{
    public class TestDemo
    {

        [Test]
        public void Test1()
        {
            //  RealClass r = new RealClass();

            FakeClass f = new FakeClass();
            Client1 ob = new Client1(f);
            var res = ob.AddClient1(10, 20);// 

            Assert.That(res, Is.EqualTo("the sum is 30"));

        }
        [Test]
        public void Test2()
        {
            Fakecls f = new Fakecls();// which is using the list
            Client1 ob = new Client1(f);
            var res = ob.AddClient("u");// 

            Assert.That(res.Count, Is.GreaterThan(0));


        }

    }

}
