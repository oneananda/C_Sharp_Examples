using Liskov_Substitution_Principle.Financial_Transactions;

namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account savings = new SavingsAccount();
            Account checking = new CheckingAccount();

            TransactionProcessor processor = new TransactionProcessor();

            // Deposit into savings account
            processor.ProcessDeposit(savings, 2000);
            // Withdraw from savings account
            processor.ProcessWithdrawal(savings, 500);

            // Deposit into checking account
            processor.ProcessDeposit(checking, 1500);
            // Withdraw from checking account
            processor.ProcessWithdrawal(checking, 2000);

            Console.ReadLine();
        }
    }
}
