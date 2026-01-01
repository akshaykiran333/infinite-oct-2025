using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NunitAssignment
{
    public class SetupTeardownTests
    {
        [SetUp]
        public void SetUp()
        {
            WriteLine(" SetUp: Runs BEFORE each test");
        }

        [TearDown]
        public void TearDown()
        {
            WriteLine(" TearDown: Runs AFTER each test");
        }

        [Test]
        public void Test1()
        {
            WriteLine("Running Test 1");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            WriteLine("Running Test 2");
            Assert.Pass();
        }
    }
}
