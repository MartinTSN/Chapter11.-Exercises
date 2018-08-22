using System;

public class Parellelogram : Quadrilateral
{
    private decimal h;
    public Parellelogram(decimal x1, decimal x2, decimal y1, decimal y2)
        : base(x1, x2, y1, y2)
    {

    }

    public decimal height()
    {
        /* decimal c = Y1 - X1;
         decimal d = Y2 - X2;
         decimal b = X2 - X1;
         decimal a = Y2 - Y1;
         decimal toRoot = (-a + b + c + d) * (a - b + c + d) * (a - b + c - d) * (a - b - c + d);
         decimal toDevide = 2 * (b - a);
         h = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(toRoot))) / Convert.ToDecimal(toDevide);
         return h;*/


        decimal b = X2 - X1;
        decimal a = Y2 - Y1;


    }
}

