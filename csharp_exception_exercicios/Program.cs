using csharp_exception_exercicios.Entities;
using csharp_exception_exercicios.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data: ");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw Limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, balance, withdrawLimit);

    Console.Write("\nEnter amount for withdraw: ");
    account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

    Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
} catch(DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}