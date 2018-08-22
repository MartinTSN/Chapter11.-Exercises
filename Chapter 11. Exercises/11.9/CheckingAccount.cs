using System;

public class CheckingAccount : Account
{
    decimal chargingFee;

    public CheckingAccount(decimal accountBalance, decimal chargingFee)
        : base(accountBalance)
    {
        ChargingFee = chargingFee;
    }

    public decimal ChargingFee
    {
        get
        {
            return chargingFee;
        }
        set
        {
            chargingFee = value;
        }
    }

    public override void AddMoney(decimal money)
    {
        AccountBalance = AccountBalance + money - chargingFee;
    }

    public override string Withdrawl(decimal money)
    {
        if (money > AccountBalance)
        {
            return "Debit amount exceeded account balance.";
        }
        else
        {
            AccountBalance = AccountBalance - money - chargingFee;
            return $"{money:C} withdrawed from account";
        }
    }
}
