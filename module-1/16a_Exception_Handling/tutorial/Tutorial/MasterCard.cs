using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    public class MasterCard : CreditCard
    {
        public override void Validate()
        {
            base.Validate();
            if (Number[0] != '5')
            {
                throw new CreditCardValidationException($"'{Number}' - Invalid MasterCard card number, must begin with '5'.");
            }
        }
    }
}
