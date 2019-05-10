using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    public class Transaction
    {
        public DateTime dateTime { get; set; }
        public decimal amount { get; set; }
        public string action { get; set; }
        public string actor { get; set; }

        //public Transaction()
        //{

        //}
        public Transaction(DateTime dateTime, decimal amount, string action, string actor)
        {
            this.dateTime = dateTime;
            this.amount = amount;
            this.action = action;
            this.actor = actor;

        }

        public override string ToString()
        {
            return $"{dateTime}{amount}{action}{actor}";
        }
    }
}
