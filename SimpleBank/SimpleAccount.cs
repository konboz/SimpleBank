using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    public class SimpleAccount : Account
    {
        public SimpleAccount(Person owner) : base(owner)
        {

        }
        public override bool Deposit(decimal amount)
        {
            return base.Deposit(amount);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Withdraw(decimal amount)
        {
            return base.Withdraw(amount);
        }
    }
}
