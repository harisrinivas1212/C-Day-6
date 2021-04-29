using System;
public class Calculator
{
    public static Tuple<int,int,int,double> AddMultiSubDiv(int a, int b)
    {
        return new Tuple<int, int,int,double>((a + b),(a * b),(a-b),(a/b));
    }
    public static void Main()
    {
        Tuple<int, int,int,double>output = Calculator.AddMultiSubDiv(3,2);
        Console.WriteLine("Sum=" +output.Item1+"Multiplication Value= "+output.Item2+"Sub Value= "+output.Item3+"Divide Value= "+output.Item4);
        Console.ReadLine();
    }
}