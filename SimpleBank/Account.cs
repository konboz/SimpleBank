using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    abstract public class Account
    {
        public Person _owner { get; private set; }
        public decimal _balance { get; private set; }
        public virtual bool Withdraw(decimal amount)
        {
            _balance -= amount;
            return true;
        }

        public Account(Person owner)
        {
            _owner = owner;
            _balance = 0;

        }
        
        public virtual bool Deposit(decimal amount)
        {
            _balance += amount;
            return true; 
        }

        //public override string ToString()
        //{
        //    return $" {_balance} {_owner.ToString()}";
        //}
    }
}
