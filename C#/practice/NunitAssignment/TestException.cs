using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{
    public class StudentService
    {
        public void ValidateAge(int age)
        {
            if (age < 0) throw new ArgumentException("Invalid age");
        }
    }

    public class TestException
    {
        [Test]
        public void ValidateAge_ShouldThrowException_WhenAgeIsNegative()
        {
          
            var service = new StudentService();

            
            Assert.Throws<ArgumentException>(() => service.ValidateAge(-3));
        }
    }
}
