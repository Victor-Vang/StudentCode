namespace BankTellerExercise
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, string accountNumber) : base(accountHolder, accountNumber)
        {

        }

        public SavingsAccount(string accountHolder, string accountNumber, decimal balance) : base(accountHolder, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            // only perform transaction of positive $ and room for fee
            if (Balance - amountToWithdraw >= 2)
            {
                base.Withdraw(amountToWithdraw);
                // Assess $2 fee if it goes below $150
                if (Balance < 150)
                {
                    base.Withdraw(2);
                }
            }
            return Balance;
        }

        public override decimal TransferTo(BankAccount destinationAccount, decimal transferAmount)
        {
            if (Balance - transferAmount < 150)
            {
                base.Withdraw(transferAmount + 2.00M);
                destinationAccount.Balance += transferAmount;
            }

            return Balance;
            //Balance -= transferAmount;
            //destinationAccount.Balance += transferAmount;
            //return this.Balance;
        }
    }
}
