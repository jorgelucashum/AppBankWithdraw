using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppBankWithdraw.Entities;
using AppBankWithdraw.Entities.Exceptions;

namespace AppBankWithdraw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite os dados da sua conta: ");
                Console.Write("Número: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string holder = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(n, holder, balance, withdrawLimit);
                Console.WriteLine("\nDados da conta:\n" + account + "\n");

                Console.Write("Digite um valor para sacar: ");
                double value = double.Parse(Console.ReadLine());
                account.Withdraw(value);
                Console.WriteLine("\nDados da conta:\n" + account + "\n");
            }
            catch(WithdrawException e)
            {
                Console.WriteLine("Erro ao realizar o saque: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }

        }
    }
}
