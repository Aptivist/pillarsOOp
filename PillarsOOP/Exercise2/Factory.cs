using System;
using PillarsOOP.Exercise2.Interfaces;

namespace PillarsOOP.Exercise2
{
    public class Factory : IBankFactory
    {
        public ITransaction GetInstance(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.Santander:
                    return new Santander();
                case BankType.AMEX:
                    return new AmericanExpress();
                case BankType.Bancomer:
                    return new BancomerV2();
                default:
                    return null;
            }
        }
    }
}
