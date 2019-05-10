using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace SimpleBank
{
    public class AnalyticAccount : Account
    {
        private const string filename = @"C:\Users\Konstantinos\Desktop\Day4_data\transactions.json";
        private readonly List<Transaction> transactions;
        public AnalyticAccount(Person owner) : base(owner)
        {
            transactions = new List<Transaction>();
        }

        public override bool Deposit(decimal amount)
        {
            transactions.Add(new Transaction(DateTime.Now, amount, "Deposit", _owner.ToString()));
            return base.Deposit(amount);
        }

        public override bool Withdraw(decimal amount)
        {
            transactions.Add(new Transaction(DateTime.Now, amount, "Withdrawal", _owner.ToString()));
            return base.Withdraw(amount);
        }

        public void PrintTransactions()
        {
            foreach (Transaction t in transactions)
            {
                Console.WriteLine(t);
            }
        }

        //public void SaveToFile(string filename)
        //{
        //    using (StreamWriter file = new StreamWriter(filename))
        //    {
        //        foreach (Transaction t in transactions)
        //        {
        //            file.WriteLine(t);
        //        }
        //    }


        public void SaveToJson()
        {
            string json = JsonConvert.SerializeObject(transactions.ToArray());
            //write string to file
            File.WriteAllText(filename, json);
        }

        public void LoadJson()
        {
            List<Transaction> newTransactions = transactions;
            string data = File.ReadAllText(filename);
            newTransactions = JsonConvert.
                DeserializeObject<List<Transaction>>(data);
         //lathos, giati?
        }
    }
}
