using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class AmericanExpress : ITransaction
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposit from AmericanExpress {amount}");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdraw from AmericanExpress {amount}");
        }
    }
}
