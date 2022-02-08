using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    public class CreditCardValidationException : Exception
    {

        public CreditCardValidationException(string message) : base(message)
        {

        }

    }
}
