using System;

class Test
{
    static void Main()
    {
        Point point1 = new Point(0, 0);
        Point point2 = new Point(8, 0);
        Point point3 = new Point(2, 3);
        Point point4 = new Point(10, 3);

        Parellelogram parellelogram = new Parellelogram(point1, point2, point3, point4);
        Console.WriteLine($"Parellelogram area is: {parellelogram.Area()}\n");

        Rectangle rectangle = new Rectangle(point1, point2, point3, point4);
        Console.WriteLine($"Rectangle area is: {rectangle.Area()}\n");

        Square square = new Square(point1, point2, point3, point4);
        Console.WriteLine($"Square area is: {square.Area()}");

        Trapezoid trapezoid = new Trapezoid(point1, point2, point3, point4);
        Console.WriteLine($"Trapezoid area is: {trapezoid.Area()}");

        Console.ReadLine();
    }
}

