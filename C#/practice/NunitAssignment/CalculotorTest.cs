namespace NunitAssignment
{
    public class Calculotor()

    {
        public int Square(int a) => a * a;
    }
    public class Tests
    {
        
       [Test]
       
        public void Square_ShouldReturnCorrectSum()
            {
                
                var calculator = new Calculotor();    
                int result = calculator.Square(2);
                Assert.That(result,Is.EqualTo(4));
            }
        }
    }

