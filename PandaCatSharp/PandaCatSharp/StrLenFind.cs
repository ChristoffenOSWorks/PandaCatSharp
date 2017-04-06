using System;
using System.Collections;
using System.Collections.Generic;

namespace PandaCat {
	public class StrLenFind : Tabby {
		public void customSpace1(String custom1, String custom2) {
			length1 = custom1.Length;
			length2 = custom2.Length;
			while (length1 > length2) {
				Console.Write (" ");
				length2 += 1;
			} 
		}
	}
}

