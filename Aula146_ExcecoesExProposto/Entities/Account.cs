/* >>> CLASSE ACCOUNT <<< */
using System;
using System.Globalization;
using Aula146_ExcecoesExProposto.Entities.Exceptions;

namespace Aula146_ExcecoesExProposto.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = amount;
        }

        public void Withdraw(double amount, double withdrawLimit)
        {
            if (amount > withdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
