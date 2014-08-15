using System;

class ClassWithNames {
	public int fieldA;
	public readonly string fieldB;

	public void MethodA(int a, int b) { }
	public void MethodB<T>(T arg) { }
	public int MethodC() { return 3; }

	public class InnerClass { }

	public void Print() {
		Console.WriteLine(nameof(fieldA));
		Console.WriteLine(nameof(fieldB));
		Console.WriteLine(nameof(MethodA));
		Console.WriteLine(nameof(MethodB));
		// compilation error: Identifier expected
		// Console.WriteLine(nameof(MethodB<int>));
		Console.WriteLine(nameof(MethodC));
		Console.WriteLine(nameof(InnerClass));

		Console.WriteLine(nameof(Console));
		// Namespace part is ommited, this writes 'Console'
		Console.WriteLine(nameof(System.Console));
		// Writes simply 'List'
		Console.WriteLine(nameof(System.Collections.Generic.List<>));
	}
}

public class Program {
	public static void Main() {
		var c = new ClassWithNames();
		c.Print();
	}
}
