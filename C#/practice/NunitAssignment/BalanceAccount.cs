using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{
    public class BalanceAccount
    {
        public class Account
        {
            public decimal Balance { get; private set; }

            public Account(decimal initialBalance)
            {
                Balance = initialBalance;
            }

            public void Deposit(decimal amount) => Balance += amount;
        }

        [TestFixture]
        public class AccountTests
        {
            [Test]
            public void Deposit_AddsAmountToBalance()
            {
               
                var account = new Account(1000m);

               
                account.Deposit(200m);

                
                Assert.That(account.Balance, Is.EqualTo(1200m));

            }
        }
    }
}
