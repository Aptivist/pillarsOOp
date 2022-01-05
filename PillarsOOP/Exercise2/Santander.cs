using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class Santander : ITransaction
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposit from Santander {amount}");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdraw from Santander {amount}");
        }
    }
}
