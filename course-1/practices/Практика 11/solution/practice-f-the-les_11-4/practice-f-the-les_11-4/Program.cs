using System;

public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Недостаточно средств!");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Баланс: {balance}");
    }
}