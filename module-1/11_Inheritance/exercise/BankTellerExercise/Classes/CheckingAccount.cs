namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }


        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal result = Balance - amountToWithdraw;
            if (result <= -100.00M)
            {
                return Balance;
            }

            base.Withdraw(amountToWithdraw);
            
            if (Balance < 0)
            {
                base.Withdraw(10.00M);
            }

            return Balance;
        }
    }
}





