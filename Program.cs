using System;

namespace bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new BankAccount("sato.yuki", 1000);
                Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial Balance.");
                account.MakeWithDrawal(500, DateTime.Now, "Rent payment");
                Console.WriteLine(account.Balance);
                account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
                Console.WriteLine(account.Balance);
                //account.MakeWithDrawal(750, DateTime.Now, "Attempt to overdraw");

                Console.WriteLine(account.GetAccountHistory());

                // Test that the initial balances must be positive.
                BankAccount invalidAccount;
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
                return;
            }
        }
    }
}
