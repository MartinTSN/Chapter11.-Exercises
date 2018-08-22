using System;

public class SavingsAccount : Account
{
    private decimal interestRate;

    public SavingsAccount(decimal interestRate)
        :base(accountBalance)
        
    {

    }


    public decimal CalculateInterest(decimal money)
    {
        return interestRate * AccountBalance;
    }
}