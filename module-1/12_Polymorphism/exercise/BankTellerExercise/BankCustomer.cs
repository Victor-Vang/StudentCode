using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                decimal totalBalance = 0.00M;
                foreach (IAccountable item in Accounts)
                {
                    totalBalance += item.Balance;
                }
                if (totalBalance >= 25000.00M)
                {
                    return true;
                }
                return false;
            }
        }
        private List<IAccountable> Accounts { get; set; } = new List<IAccountable>();

        public void AddAccount(IAccountable newAccount)
        {
            Accounts.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            return Accounts.ToArray();
        }

    }
}
