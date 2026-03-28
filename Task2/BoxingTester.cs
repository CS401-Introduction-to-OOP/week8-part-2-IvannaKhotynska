namespace Task2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        
        Console.WriteLine($"a - {a}");
        Console.WriteLine($"b - {b}");
        Console.WriteLine($"c - {c}");
        
        /* тут зробили boxing a - і записали в b
         а у змінній с - unboxing b
         */
        
    }
}
