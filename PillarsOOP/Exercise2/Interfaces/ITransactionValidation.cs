using System;
namespace PillarsOOP.Exercise2.Interfaces
{
    public interface ITransactionValidation
    {
        bool IsDepositSupported { get; }
        bool IsWithDrawSupported { get; }
    }
}
