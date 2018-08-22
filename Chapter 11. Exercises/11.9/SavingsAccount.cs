using System;

public class SavingsAccount : Account
{
    private decimal interestRate;

    public SavingsAccount(decimal accountBalance, decimal interestRate)
        : base(accountBalance)

    {
        InterestRate = interestRate;
    }

    public decimal InterestRate
    {
        get
        {
            return interestRate;
        }
        set
        {
            interestRate = value;
        }
    }

    public decimal CalculateInterest()
    {
        return interestRate * AccountBalance;
    }
}