using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class Bancomer : IDeposit, ITransactionValidation
    {
        public bool IsDepositSupported => throw new NotImplementedException();

        public bool IsWithDrawSupported => throw new NotImplementedException();

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposit from Bancomer {amount}");
        }
    }
}
