using System;
using System.Collections;
using System.Collections.Generic;

public class BoxParts : PandaCat {
		
	public void subheading1() {
		length1 = crtThree.Length;
		Console.Write (newline + Space3 + LW);
		while (length1 > 0) {
			Console.Write (subheading);
			length1 -= 1;
		}
		Console.Write (RW);
	}

	public void convertSubheading() {
		length1 = convertR.Length;
		Console.Write (newline + Space3 + LW);
		while (length1 > 0) {
			Console.Write (subheading);
			length1 -= 1;
		}
		Console.Write (RW);
	}

	public void customSub(String custom1) {
		int length0 = custom1.Length;
		Console.Write (newline + Space3 + LW);
		while (length0 > 0) {
			Console.Write (subheading);
			length0 -= 1;
		}
		Console.Write (RW);
	}


	public void convertHeadingTop() {
		length1 = convertR.Length;
		Console.Write (newline + Space3 + TL);
		while (length1 > 0) {
			Console.Write (heading);
			length1 -= 1;
		}			
		Console.Write (TR);
	}

	public void convertHeadingBottom() {
		length1 = convertR.Length;
		Console.Write (newline + Space3 + BL);
		while (length1 > 0) {
			Console.Write (heading);
			length1 -= 1;
		}	
		Console.Write (BR);
	}

	public void head2() {
		length1 = result1.Length;
		Console.Write (Space3);
		while (length1 > 0) {
			Console.Write (heading);
			length1 -= 1;
		}
	}

	public void subheading2() {
		length1 = result1.Length;
		Console.Write (Space3);
		while (length1 > 0) {
			Console.Write (subheading);
			length1 -= 1;
		}
	}

	public void head1FullTop() {
		length1 = crtThree.Length;
		Console.Write (newline + Space3 + TL);
		while (length1 > 0) {
			Console.Write (heading);
			length1 -= 1;
		}			
		Console.Write (TR);
	}

	public void head1FullBottom() {
		length1 = crtThree.Length;
		Console.Write (newline + Space3 + BL);
		while (length1 > 0) {
			Console.Write (heading);
			length1 -= 1;
		}	
		Console.Write (BR);
	}

	public void subHead() {
		Console.Write (Space3 + LW);
		subheading1 ();
		Console.Write (RW);
	}
}


