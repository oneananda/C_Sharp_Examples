using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.Financial_Transactions
{
    public abstract class Account
    {
        public decimal Balance { get; protected set; }

        public abstract void CheckBalance();
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }

    public class SavingsAccount : Account
    {
        private const decimal MinimumBalance = 1000;

        public override void CheckBalance()
        {
            Console.WriteLine($"Current Balance : " + Balance.ToString());
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < MinimumBalance)
            {
                throw new InvalidOperationException("Withdrawal denied. Minimum balance must be maintained.");
            }
            Balance -= amount;
        }
    }

    public class CheckingAccount : Account
    {
        public override void CheckBalance()
        {
            Console.WriteLine($"Current Balance : " + Balance.ToString());
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;
        }
    }

}
