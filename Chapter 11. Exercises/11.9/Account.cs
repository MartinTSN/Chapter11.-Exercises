using System;

public class Account
{
    private decimal accountBalance;

    public Account(decimal accountBalance)
    {
        AccountBalance = accountBalance;
    }

    public decimal AccountBalance
    {
        get
        {
            return accountBalance;
        }
        set
        {
            if (value < 0.0m)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "must be greater or equal to 0.0m");
            }
            accountBalance = value;
        }
    }

    public virtual void AddMoney(decimal money)
    {
        AccountBalance = AccountBalance + money;
    }

    public virtual string Withdrawl(decimal money)
    {
        if (money > AccountBalance)
        {
            return "Debit amount exceeded account balance.";
        }
        else
        {
            AccountBalance = AccountBalance - money;
            return $"{money:C} withdrawed from account";
        }
    }
}