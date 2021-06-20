using System;
namespace bankaccount
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {
        }

        public override void PeformMonthEndTransactions()
        {
            //base.PeformMonthEndTransactions();
            if(Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                var interest = -Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }

        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
            //return base.CheckWithdrawalLimit(isOverdrawn);
            isOverdrawn
                ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
                : default;
    }
}
