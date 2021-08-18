using BankyStuffLibrary;
using System;
using Humanizer;

namespace MySuperBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(3501.ToWords());
            //Console.WriteLine("Car".Pluralize());
            //Console.WriteLine("Pant".Pluralize());
            //Console.WriteLine("Octopus".Pluralize());


            var account = new BankAccount("Peace", 100000);
            Console.WriteLine($"Bank Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            //Make Withdrawal
            account.MakeWithdrawal(3000, DateTime.Now, "Purchase of Phone Charger");
            Console.WriteLine($"Account Balance after the last purchase is {account.Balance}");


            Console.WriteLine(account.GetAccountHistory());

            ////Test the initial balances are positive
            ////Try-Catch is used when trying to figure out what part of your code would break
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e) 
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            ////Test for over withdrawal
            //try
            //{
            //    account.MakeWithdrawal(200000, DateTime.Now, "Purchase of Shoe");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to Overdraw");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
