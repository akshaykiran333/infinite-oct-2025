using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment

{
    public class ParameterizedTest
    {
        public int Multiply(int a, int b) => a * b;
    }

    public class CalculatorTests
    {
        [TestCase(2, 3, 6)]
        [TestCase(-1, 5, -5)]
        [TestCase(0, 19, 0)]
        public void Multiply_ShouldReturnCorrectResult(int a, int b, int c)
        {
            
            var st = new ParameterizedTest(); 

           
            int result = st.Multiply(a, b);    

           
            Assert.That(result, Is.EqualTo(c));
        }
    }
}
