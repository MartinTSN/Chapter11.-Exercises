using System;

public class Quadrilateral
{
    private decimal x1;
    private decimal x2;
    private decimal y1;
    private decimal y2;

    public Quadrilateral(decimal x1, decimal x2, decimal y1, decimal y2)
    {
        X1 = x1;
        X2 = x2;
        Y1 = y1;
        Y2 = y2;
    }
    public decimal X1
    {
        get
        {
            return x1;
        }
        set
        {
            x1 = value;
        }
    }

    public decimal X2
    {
        get
        {
            return x2;
        }
        set
        {
            x2 = value;
        }
    }
    public decimal Y1
    {
        get
        {
            return y1;
        }
        set
        {
            y1 = value;
        }
    }
    public decimal Y2
    {
        get
        {
            return y2;
        }
        set
        {
            y2 = value;
        }
    }

    public virtual decimal Area()
    {
        return (X1 - X2) * (Y1 - Y2);
    }
}

