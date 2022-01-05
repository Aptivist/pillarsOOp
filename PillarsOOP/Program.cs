using System;
using System.Collections.Generic;
using PillarsOOP.Exercise2;
using PillarsOOP.Exercise2.Interfaces;
using PillarsOOP.ExerciseRentalCars.Interfaces;
using PillarsOOP.ExerciseRentalCars.Models;
using PillarsOOP.Interfaces;
using PillarsOOP.Models;

namespace PillarsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory();
            //what bank?
            //1.santader
            //2.bancomer
            //3. amex
            var bancomer = new Bancomer();
            //var santander = new Santander();
            var atm = new ATM(bancomer, null, bancomer);
            //var atm2 = new ATM(santander, santander, santander);
            //what transaction?
            //1.deposit
            //2.withdraw
            var transactionType = 1;
            decimal amount = 10;

            if (atm.IsDepositSupported && transactionType == 1)
            {
                atm.Deposit(amount);
            }//else deposit not supported

            if (atm.IsWithDrawSupported && transactionType == 2)
            {
                atm.Withdraw(amount);
            }//else Withdraw not supported
        }
    }
}
