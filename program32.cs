using System;

class Account
{
    protected int accountNumber;
    protected double balance;

    public Account(int accountNumber, double balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited Amount: " + amount);
        Console.WriteLine("Updated Balance: " + balance);
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn Amount: " + amount);
            Console.WriteLine("Updated Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public virtual void Display()
    {
        Console.WriteLine("\nAccount Details");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : Account
{
    private double interestRate;

    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        this.interestRate = interestRate;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Savings Account: " + amount);
            Console.WriteLine("Updated Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Insufficient Balance in Savings Account");
        }
    }

    public override void Display()
    {
        Console.WriteLine("\nSavings Account Details");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}

class CurrentAccount : Account
{
    private double minimumBalance;

    public CurrentAccount(int accountNumber, double balance, double minimumBalance)
        : base(accountNumber, balance)
    {
        this.minimumBalance = minimumBalance;
    }

    public override void Withdraw(double amount)
    {
        if ((balance - amount) >= minimumBalance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Current Account: " + amount);
            Console.WriteLine("Updated Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Cannot withdraw. Minimum balance must be maintained.");
        }
    }

    public override void Display()
    {
        Console.WriteLine("\nCurrent Account Details");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Minimum Balance: " + minimumBalance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account a = new Account(100, 3000);
        SavingsAccount s = new SavingsAccount(101, 5000, 5);
        CurrentAccount c = new CurrentAccount(102, 8000, 2000);

        a.Display();
        a.Deposit(500);
        a.Withdraw(1000);

        s.Display();
        s.Deposit(1000);
        s.Withdraw(2000);

        c.Display();
        c.Deposit(1500);
        c.Withdraw(7000);
    }
}