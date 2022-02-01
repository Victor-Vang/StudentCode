namespace BankTellerExercise.Classes
{
    public class BankAccount
    {

        // constructors

        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        // properties

        public string AccountHolderName { get; private set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; private set; } = 0.00M;

        // methods

        public decimal Deposit(decimal amountToDeposit)
        {
            Balance = amountToDeposit + Balance;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance = Balance - amountToWithdraw;
            return Balance;
        }

    }
}
