using System;

namespace HelloWorld
{
  public class tupple
	{
		public static Tuple<double,double> AddMulti(double a,double b)
		{
			return new Tuple<double, double>((a+b), (a*b));
		}
		
		static void Main(string[] args)
		{
			Tuple<double, double> output = tupple.AddMulti(3.4,3.2);
			Console.WriteLine("sum = "+output.Item1+"Multiplication Value = "+output.Item2);
			Console.ReadLine();
			
		}
	}
}
