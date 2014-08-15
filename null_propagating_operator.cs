using System;

public static class Program {
	public static void Main() {
		var datum = new {
			foo = 3,
			bar = new {
				baz = "super",
				buz = (string)null,
			},
		};


		Console.WriteLine(datum?.bar?.baz?.ToString() ?? "null");
		Console.WriteLine(datum?.bar?.buz?.ToString() ?? "null");
	}
}
