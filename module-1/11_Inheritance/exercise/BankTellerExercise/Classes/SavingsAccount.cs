namespace BankTellerExercise.Classes
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
            if (Balance <= amountToWithdraw)
            {
                return Balance;
            }

            base.Withdraw(amountToWithdraw);

            if (Balance - amountToWithdraw < 150.00M)
            {
                base.Withdraw(2.00M);
            }

            return Balance;

        }

    }
}
