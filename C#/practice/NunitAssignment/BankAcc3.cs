using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment
{
    public class BankAcc3
    {
        [TestFixture]
       
           
            public class Account
            {
                public decimal Balance { get; private set; }

                public Account(decimal initialBalance)
                {
                    Balance = initialBalance;
                }

                public void Withdraw(decimal amount)
                {
                    if (amount > Balance)
                        throw new InvalidOperationException("Insufficient funds");

                    Balance -= amount;
                }
            }

           

            [Test]
            public void Withdraw_ShouldDecreaseBalance_WhenAmountIsValid()
            {
               
                var account = new Account(500m);
               
                account.Withdraw(300m);

                Assert.That(account.Balance, Is.EqualTo(200m));
            }

            [Test]
            public void Withdraw_ShouldThrowException_WhenAmountExceedsBalance()
            {
                
                var account = new Account(500m);

                Assert.That(
                    () => account.Withdraw(600m),
                    Throws.InvalidOperationException.With.Message.EqualTo("Insufficient funds")
                );
            }
        }
}
