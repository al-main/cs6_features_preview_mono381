using System;

public class Constants {
	public static double PI { get; } = 3.141592;
	public static bool IsTestEnvironment { get; internal set; } = true;
	// This works in exactly the same way for instance properties
}

public class Program {
	public static void Main() {
		Console.WriteLine(Constants.PI);
		Console.WriteLine(Constants.IsTestEnvironment);
	}
}
