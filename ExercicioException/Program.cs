using ExercicioException.Entities;
using System;
using System.Globalization;

namespace ExercicioException
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc1 = new Account(number, holder, initialBalance, withdrawLimit);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc1.Withdraw(amount);

                Console.WriteLine($"New balance: {acc1.Balance.ToString("F2", CultureInfo.InvariantCulture)} ");
            }
            catch(Accountexception e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}
