using System;
namespace PillarsOOP.Exercise2.Interfaces
{
    public interface IBankFactory
    {
        ITransaction GetInstance(BankType bankType);
    }

    public enum BankType
    {
        Santander = 1,
        AMEX = 2,
        Bancomer = 3
    }
}
