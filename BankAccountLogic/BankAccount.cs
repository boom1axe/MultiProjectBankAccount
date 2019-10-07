using System;

namespace BankAccountBusinessLogic
{
    public class BankAccount
    {


        /// <summary>
        /// Creates a bank account with given
        /// account number. The account number
        /// can be any alphanumeric string.
        /// </summary>
        /// <param name="accNum"></param>
        public BankAccount(string accNum)
        {
            this.AccountNumber = accNum;
        }

        public string AccountNumber { get; private set; }

        public double Balance { get; private set; }
        
        /// <summary>
        /// Adds a given amount to the balance. returns
        /// the new balance.
        /// </summary>
        /// <param name="amt">The positive amount to deposit</param>
        /// <returns></returns>
        public double Deposit (double amt)
        {
            if (amt <= 0)
            {
                throw new ArgumentException($"{nameof(amt)} must be positive!");
            }

            Balance += amt;
            return Balance;
        }

        /// <summary>
        /// Withdraws a gigven amount from the balance.
        /// Returns the balance minus the amount withdrawn
        /// </summary>
        /// <param name="amt"></param>
        /// <returns></returns>
        public double Withdraw(double amt)
        {
            Balance -= amt;
            return Balance;
        }
    }
}
