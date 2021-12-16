using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money would you like to deposit?");
            var userInput = double.Parse(Console.ReadLine());
            BankAccount balance = new BankAccount();
            balance.Deposit(userInput);
            Console.WriteLine($"Your new balance is {balance.GetBalance()}");
            Console.WriteLine("How much money would you like to withdraw?");
            var userWithdraw = double.Parse(Console.ReadLine());
            balance.Withdraw(userWithdraw);
            Console.WriteLine($"Your new balance is {balance.GetBalance()}");

        }



    }
}
