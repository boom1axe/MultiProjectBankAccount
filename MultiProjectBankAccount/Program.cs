using BankAccountBusinessLogic;
using System;
using static System.Console;

namespace MultiProjectBankAccount
{
    class Program
    {
        static void Main()
        {
            WriteLine("Welcome to Robbers Bank!");
            WriteLine("Please enter an account number: ");

            string accNum = ReadLine();
            BankAccount acc = new BankAccount(accNum);

            WriteLine("\n \n Enter an amount to deposit:");
            double amount = Convert.ToDouble(ReadLine());

            acc.Deposit(amount);
            WriteLine($"the new balance is: {acc.Balance}");
            ReadKey();
        }
    }
}
