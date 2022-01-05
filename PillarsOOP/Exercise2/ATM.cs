using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class ATM : IDeposit, IWithdraw
    {
        public IDeposit DepositService { get; set; }
        public IWithdraw WithdrawService { get; set; }

        public void Deposit(decimal amount)
        {
            DepositService?.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            WithdrawService?.Withdraw(amount);
        }
    }
}
