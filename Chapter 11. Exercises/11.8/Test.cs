using System;

class Test
{
    static void Main()
    {
        double x;
        double y;

        Console.WriteLine("Whats the X cordinate of the first point?");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Whats the Y cordinate of the first point?");
        y = double.Parse(Console.ReadLine());
        Point point1 = new Point(x, y);

        Console.WriteLine("Whats the X cordinate of the second point?");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Whats the Y cordinate of the second point?");
        y = double.Parse(Console.ReadLine());
        Point point2 = new Point(x, y);

        Console.WriteLine("Whats the X cordinate of the third point?");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Whats the Y cordinate of the third point?");
        y = double.Parse(Console.ReadLine());
        Point point3 = new Point(x, y);

        Console.WriteLine("Whats the X cordinate of the fourth point?");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Whats the Y cordinate of the fourth point?");
        y = double.Parse(Console.ReadLine());
        Point point4 = new Point(x, y);

        Parellelogram parellelogram = new Parellelogram(point1, point2, point3, point4);

        Console.WriteLine($"Area is: {parellelogram.Area()}");


        Console.ReadLine();
    }
}

