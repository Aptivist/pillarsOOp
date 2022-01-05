using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class ATM : IDeposit, IWithdraw, ITransactionValidation
    {
        private IDeposit _depositService;
        private IWithdraw _withdrawService;
        private ITransactionValidation _transactionValidation;

        public bool IsDepositSupported => _transactionValidation.IsDepositSupported;
        public bool IsWithDrawSupported => _transactionValidation.IsWithDrawSupported;

        public ATM(IDeposit deposit, IWithdraw withdraw, ITransactionValidation transaction)
        {
            _depositService = deposit;
            _withdrawService = withdraw;
            _transactionValidation = transaction;
        }

        public void Deposit(decimal amount)
        {
            _depositService?.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            _withdrawService?.Withdraw(amount);
        }
    }
}
