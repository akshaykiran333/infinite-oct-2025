using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{
    public class BankAccount
    {
            public decimal Balance { get; private set; }
            public BankAccount(decimal openingBalance) => Balance = openingBalance;
        
    }
    public class BankAccountTests
    {
        [Test]
        public void OpeningBalance_ShouldBe500_WhenSetTo500()
        {
           
            decimal openingBalance = 500m;

           
            var account = new BankAccount(openingBalance);

            
            Assert.That(account.Balance, Is.EqualTo(500m));
        }
    }
}
