using System;

public class ErrorCodeException : Exception {
	public int ErrorCode {
		get {
			return (int) this.Data["errorCode"];
		}

		set {
			this.Data["errorCode"] = value;
		}
	}

	public ErrorCodeException(int errorCode)
		: base()
	{
		this.ErrorCode = errorCode;
	}
}

public class Program {
	public static void Main() {
		for(int i = 0; i < 10; i++) {
			try {
				ThrowErrorCode(i);
			}
			// syntax: catch (exception) if (condition) { ... }
			catch(ErrorCodeException ex) if (ex.ErrorCode <= 5) {
				Console.WriteLine("ErrorCode <= 5");
			}
			catch(ErrorCodeException ex) {
				Console.WriteLine("No condition");
			}
		}
	}

	private static void ThrowErrorCode(int errorCode) {
		throw new ErrorCodeException(errorCode);
	}
}
