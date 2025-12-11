using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{
    public class StringHelperTest
    {
        public string ToUpper(string input) => input.ToUpper();
    }
    public class StringHelper {

        [Test]
        public void ToUpper() {

            StringHelperTest st = new StringHelperTest();

            string result = st.ToUpper("hello");

            Assert.Multiple(() => {
                Assert.That(result.Length, Is.EqualTo(5));
                Assert.That(result[0], Is.EqualTo('H'));
                Assert.That(result, Is.EqualTo("HELLO"));
            });
        }
    
    }
}
