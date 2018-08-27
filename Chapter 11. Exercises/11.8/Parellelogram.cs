using System;

public class Parellelogram : Quadrilateral
{
    public Parellelogram(Point point1, Point point2, Point point3, Point point4)
        : base(point1, point2, point3, point4)
    {

    }

    public override double Area()
    {
        double b = Point1.X - Point2.X;
        double a = Point1.Y - Point3.Y;

        Point pointMini = new Point(b / 2, Point3.Y);

        double miniB = Point3.X - pointMini.X;

        if (b < 0)
        {
            b = Math.Abs(b);
        }
        if (a < 0)
        {
            a = Math.Abs(a);
        }
        if (miniB < 0)
        {
            miniB = Math.Abs(miniB);
        }
        return b * Math.Sqrt(Math.Abs((a * a) - (miniB * miniB)));

    }
}

