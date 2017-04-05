using System;

public class EmptyException : Exception {
	public EmptyException (String s) {
		if (String.IsNullOrEmpty(s)) {
			Console.Clear ();
			Console.Write("Failed");
		} 
	}
}


