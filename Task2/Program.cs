using Task2;

class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = new Point { X = 3, Y = 4 };
        p1.Print();
        p2.Print();
        
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = new PointRef { X = 7, Y = 8 };
        r1.Print();
        r2.Print();
        
        BoxingTester.Test();
    }
}    