using System;

public class Foo {
	private int times = 0;
	// This is translated to read-only property
	public string Times => string.Format("Called {0} times!", ++times);

	public double Square(double x)
		=> x * x;

	public double Cube(double x)
		=> x * Square(x);
}

public static class Program {
	public static void Main(string[] args) {
		var foo = new Foo();
		Console.WriteLine(foo.Times);
		Console.WriteLine(foo.Times);

		// error: Times is read only
		// foo.Times = "bar";

		Console.WriteLine(foo.Square(3));
		Console.WriteLine(foo.Cube(3));
	}
}
	
