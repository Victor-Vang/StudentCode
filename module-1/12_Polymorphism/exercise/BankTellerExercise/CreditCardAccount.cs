using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {

            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;

        }

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; }
        public decimal Balance { get; private set; }

        public decimal Pay(decimal amountToPay)
        {
            Debt -= amountToPay;
            Balance = Debt * -1;
            return Balance;
        }

        public decimal Charge(decimal amountToCharge)
        {
            Debt += amountToCharge;
            Balance = Debt * -1;
            return Balance;
        }
    }
}
