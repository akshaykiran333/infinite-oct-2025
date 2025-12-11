using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{
    public class StringConstraints
    {
        [Test]
        public void NUnitFramework_StringConstraints()
        {
            string text = "NUnitFramework";

            Assert.Multiple(() =>
            {
               
                Assert.That(text, new StartsWithConstraint("NUnit"));

              
                Assert.That(text, new EndsWithConstraint("work"));

                
                Assert.That(text, new SubstringConstraint("Frame"));

            
                Assert.That(text, Has.Length.EqualTo(14));
            });
        }
    }
}

    


