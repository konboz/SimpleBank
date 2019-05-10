using System;

namespace SimpleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimitris = new Person(1, "Dimitris", "Athens");
            var account = new AnalyticAccount(dimitris);

            account.LoadJson(); //loads previous transactions
            account.Deposit(1);
            account.Deposit(2);
            account.Withdraw(1);
            account.PrintTransactions();
            account.SaveToJson();

            Console.ReadLine();
        }
    }
}
