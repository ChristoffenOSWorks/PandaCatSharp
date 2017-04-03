using System;
using System.Collections;
using System.Collections.Generic;

//For finding the length of strings 
//to dynamically get this right the first time
public class StrLenFind : PandaCat {
	public void crt3Remaining() {
		length1 = crtThree.Length;
		length2 = crtOne.Length;
		while (length1 > length2) {		
			Console.Write (" ");
			length2 += 1;
		} 
	}

	public void crt2Remaining() {
		length1 = crtThree.Length;
		length2 = crtTwo.Length;
		while (length1 > length2) {		
			Console.Write (" ");
			length2 += 1;
		} 
	}

	public void result1Space() {
		length1 = crtThree.Length;
		length2 = result1.Length;
		while (length1 > length2) {
			Console.Write (" ");
			length2 += 1;
		} 
	}

	public void exitSpace() {
		length1 = crtThree.Length;
		length2 = exit.Length;
		while (length1 > length2) {
			Console.Write (" ");
			length2 += 1;
		} 
	}

	public void convertSpaceC() {
		length1 = convertR.Length;
		length2 = Step1C.Length;
		while (length1 > length2) {
			Console.Write (" ");
			length2 += 1;
		} 
	}

	public void convertSpace() {
		length1 = convertR.Length;
		length2 = Step1.Length;
		while (length1 > length2) {
			Console.Write (" ");
			length2 += 1;
		} 
	}

	public void customSpace(String custom1, String custom2) {
		length1 = custom1.Length;
		length2 = custom2.Length;
		while (length1 > length2) {
			Console.Write (" ");
			length2 += 1;
		} 
	}
}

