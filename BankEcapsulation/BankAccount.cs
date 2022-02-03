using System;
using System.Collections.Generic;
using System.Text;

namespace BankEcapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        private double balance = 0;
        
        //Encapsulation
        public void Deposit(double amount)
        {
            balance = amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        
    }
}
