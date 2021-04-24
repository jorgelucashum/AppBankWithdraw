using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppBankWithdraw.Entities.Exceptions;

namespace AppBankWithdraw.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        
        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            if (Balance <= 0 || value > Balance)
            {
                throw new WithdrawException("Não há saldo suficiente para realizar a operação.");
            }
            if(value > WithdrawLimit )
            {
                throw new WithdrawException("O saque ultrapassa o limite da conta.");
            }
            Balance -= value;
        }

        public override string ToString()
        {
            return $"Número da conta: {Number}, Titular: {Holder}, Saldo: R${Balance.ToString("F2")}, Limite de saque: R${WithdrawLimit.ToString("F2")}.";
        }

    }
}
