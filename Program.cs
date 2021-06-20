using System;

namespace bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithDrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithDrawal(50, DateTime.Now, "buy groceries");
            giftCard.PeformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithDrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PeformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithDrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithDrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PeformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());

            //try
            //{
            //    var account = new BankAccount("sato.yuki", 1000);
            //    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial Balance.");
            //    account.MakeWithDrawal(500, DateTime.Now, "Rent payment");
            //    Console.WriteLine(account.Balance);
            //    account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            //    Console.WriteLine(account.Balance);
            //    account.MakeWithDrawal(750, DateTime.Now, "Attempt to overdraw");

            //    Console.WriteLine(account.GetAccountHistory());

            //    // Test that the initial balances must be positive.
            //    BankAccount invalidAccount;
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}
            //catch(InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}
        }
    }
}
