using System;
using System.Collections;

[Serializable]
internal class EmptyException : Exception
{
//	public EmptyException() {
//		Console.Write ("Failed already?");
//		while (String.IsNullOrEmpty (r)) {
//			r = Console.ReadLine ();
//			continue;
//		}
//	}


	public EmptyException() : base() {
//		ColorConverter info = new ColorConverter ();
//		String r = Console.ReadLine ();
//		while (String.IsNullOrEmpty (info.r0)) {
//			info.toRGB_R (r, info.r0, info.r1, info.r2, info.r3, info.r4);
//			break;
//		}
	}

//	public MyCustomException(string message, Exception innerException) : base(message, innerException) {
//	}
		
}



