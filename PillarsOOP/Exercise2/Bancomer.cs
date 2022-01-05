using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class Bancomer : IDeposit
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposit from Bancomer {amount}");
        }
    }
}
