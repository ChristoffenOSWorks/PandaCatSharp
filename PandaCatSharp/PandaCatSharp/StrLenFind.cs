using System;
using System.Collections;
using System.Collections.Generic;

//For finding the length of strings 
//to dynamically get this right the first time
public class StrLenFind : PandaCat {

	public void customSpace1(String custom1, String custom2) {
		length1 = custom1.Length;
		length2 = custom2.Length;
		while (length1 > length2) {
			Console.Write (" ");
			length2 += 1;
		} 
	}

}

