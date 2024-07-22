using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.Financial_Transactions
{
    public class TransactionProcessor
    {
        public void ProcessDeposit(Account account, decimal amount)
        {
            account.Deposit(amount);
            Console.WriteLine($"Deposited {amount:C} into account. New balance: {account.Balance:C}");
        }

        public void ProcessWithdrawal(Account account, decimal amount)
        {
            try
            {
                account.Withdraw(amount);
                Console.WriteLine($"Withdrew {amount:C} from account. New balance: {account.Balance:C}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Withdrawal failed: {ex.Message}");
            }
        }
    }
}
