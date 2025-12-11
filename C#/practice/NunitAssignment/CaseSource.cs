using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{

    public class StudentMarksTest
    {
        
        public static IEnumerable<int> MarksDataSource()
        {
            return new List<int> { 45, 60, 75, 90, 41 }; 
        }

        [TestCaseSource(nameof(MarksDataSource))]
        public void Marks_ShouldBeGreaterThan40(int mark)

        {
            Assert.That(mark, Is.GreaterThan(40), $"Mark {mark} is not greater than 40");
        }
    }

}
