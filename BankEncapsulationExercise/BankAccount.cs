using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    class BankAccount
    {
        private double balance = 0.00;
        public void Deposit (double Amount)
        {
            balance += Amount;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Withdraw(double Amount)
        {
            balance -= Amount;
        }
    }
}
