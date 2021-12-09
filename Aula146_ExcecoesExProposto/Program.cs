/*  Fazer um programa para ler os dados de uma conta bancária e depois realizar um
    saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
    ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
    saque da conta. Implemente a conta bancária conforme projeto abaixo:
*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;
using System.Globalization;
using Aula146_ExcecoesExProposto.Entities;
using Aula146_ExcecoesExProposto.Entities.Exceptions;

namespace Aula146_ExcecoesExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(withdraw, withdrawLimit);
                Console.WriteLine("New Balance: " + account);
            }

            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error! " + e.Message);
            }
        }
    }
}
