using System;

namespace BankEcapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myaccount = new BankAccount();

            Console.WriteLine("How much $$ do you want to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            myaccount.Deposit(amountToDeposit);
            double userBalance = myaccount.GetBalance();

            Console.WriteLine($"Thank you! Your balance is now {userBalance, 0:c}");


        }
    }
}
