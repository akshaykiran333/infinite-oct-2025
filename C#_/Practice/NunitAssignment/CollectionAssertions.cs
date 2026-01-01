using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{
    public class CollectionAssertions
    {
        public List<int> GetEvenNumbers() => new List<int> { 2, 4, 6, 8 };

    }

    public class CollectionTests
    {
        public List<int> GetEvenNumbers() => new List<int> { 2, 4, 6, 8 };

        [Test]
        public void GetEvenNumbers_ShouldReturnValidEvenNumberCollection()
        {
            
            var numbers = GetEvenNumbers();

            
            Assert.Multiple(() =>
            {
                
                Assert.That(numbers, Has.Count.EqualTo(4));

                
                Assert.That(numbers, Is.Ordered.Ascending);

                
                Assert.That(numbers, Has.All.Matches<int>(n => n % 2 == 0));
            });
        }
    }
}
