using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class BancomerV2 : ITransaction, ITransactionValidation
    {
        public bool IsDepositSupported => true;
        public bool IsWithDrawSupported => true;

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposit from BancomerV2 {amount}");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Deposit from Bancomer {amount}");
        }
    }
}
