using System;

namespace ConsoleApp1.src.OopPriciples.Encapsulation;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        Deposite(balance);
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposite(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposite must be positive.");
        }
        this.balance += amount;
    }



    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withhdeaw amount must be positive.");
        }
        if (amount > balance)
        {
            throw new InvalidCastException("Insuficient Balance");
        }

        this.balance -= amount;
    }
}
