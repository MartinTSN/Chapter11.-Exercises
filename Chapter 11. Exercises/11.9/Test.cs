using System;

class Test
{
    static void Main()
    {
        Account account = new Account(450);
        SavingsAccount savingsAccount = new SavingsAccount(350, 0.05m);
        CheckingAccount checkingAccount = new CheckingAccount(550, 50);

        Console.WriteLine(account.AccountBalance);
        Console.Write("How much will you deposit\n");
        account.AddMoney(int.Parse(Console.ReadLine()));

        Console.WriteLine(account.AccountBalance);
        Console.WriteLine("How much will you withdraw\n");
        Console.WriteLine(account.Withdrawl(int.Parse(Console.ReadLine())));

        Console.WriteLine(account.AccountBalance);
        Console.Write("\n");

        Console.WriteLine(checkingAccount.AccountBalance);
        Console.Write("How much will you deposit\n");
        checkingAccount.AddMoney(int.Parse(Console.ReadLine()));

        Console.WriteLine(checkingAccount.AccountBalance);
        Console.WriteLine("How much will you withdraw\n");
        Console.WriteLine(checkingAccount.Withdrawl(int.Parse(Console.ReadLine())));

        Console.WriteLine(checkingAccount.AccountBalance);

        Console.Write("\n");
        Console.WriteLine(savingsAccount.AccountBalance);
        savingsAccount.AddMoney(savingsAccount.CalculateInterest());
        Console.WriteLine(savingsAccount.AccountBalance);

        Console.ReadLine();
    }
}

