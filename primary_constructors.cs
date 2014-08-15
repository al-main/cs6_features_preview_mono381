using System;

public class Person(string name, string surname) : object {
	public readonly string fullname = name + " " + surname;

	// You can also assign to read-write properties
	// e.g. public string Foo { get; set; } = value;
	public string Name { get; } = name;
	public string Surname { get; } = surname;
	public int? Age { get; private set; } = null;

	// To verify constructor arguments you must use external library
	// e.g. public string Name { get; } = Verify.NonNull(surname, "surname");

	public Person(string name, string surname, int age)
		: this(name, surname) 
		// Other constructors MUST call primary constructor
	{
		this.Age = age;
	}

	public void DoSomething() {
		// Primary constructor parameters are accessible only
		// in field/property initializers
		// name.ToString();
	}

	public override string ToString() {
		return string.Format(
			"Name: {0}, Surname: {1}, Age: {2}", 
			Name, Surname, (object)Age ?? "unknown");
	}
}

// Point(private readonly int x, int y)
// currently usupported on mono
public class Point(int x, int y) {
	public readonly int X = x;
	public readonly int Y = y;

	public override string ToString() {
		return string.Format("({0}, {1})", X, Y);
	}
}

public class Program {
	public static void Main(string[] args) {
		var mc = new Person("marcin", "chwedczuk");
		Console.WriteLine(mc);

		var kirino = new Person("Kirino", "Aizawa", 15);
		Console.WriteLine(kirino);

		var p1 = new Point(33, 66);
		Console.WriteLine(p1);
	}
}
