using System;
using System.Collections;
using System.Collections.Generic;

public class TextBoxes : PandaCat {
	public BoxParts boxParts = new BoxParts();
	public StrLenFind spacer = new StrLenFind();		

	public void choiceBox () {
		boxParts.head1FullTop ();

		Console.Write (newline + Space3 + Vert + crtOne);
		spacer.crt3Remaining ();
		Console.Write(Vert);
	
		boxParts.subheading1();

		Console.Write (newline + Space3 + Vert + crtTwo); 
		spacer.crt2Remaining ();
		Console.Write(Vert);

		boxParts.subheading1 ();
		Console.Write (newline + Space3 + Vert + crtThree + Vert);
		boxParts.head1FullBottom ();
	}

	public void toCairoResultsBox() {
		boxParts.head1FullTop ();

		Console.Write (newline + Space3 + Vert + result1);
		spacer.result1Space ();
		Console.Write (Vert);

		boxParts.subheading1 ();
	}
		
	public void toCairoResultsBox2() {
		boxParts.subheading1 ();

		Console.Write (newline + Space3 + Vert + exit);
		spacer.exitSpace ();
		Console.Write(Vert);

		boxParts.head1FullBottom ();		
	}

	public void CustomBox1(String line1) {
		length1 = line1.Length;
		Console.Write (newline + Space3 + TL);
		while (length1 > 0) {
			Console.Write (heading);
			length1 -= 1;
		}			
		Console.Write (TR);

		Console.Write (newline + Space3 + Vert + line1 + Vert);

		length1 = line1.Length;
		Console.Write (newline + Space3 + BL);
		while (length1 > 0) {
			Console.Write (heading);
			length1 -= 1;
		}			
		Console.Write (BR);

	}

	public void CustomBox2(String line1, String line2) {
		length1 = line1.Length;
		length2 = line2.Length;

		if (length1 > length2) {
			//Top Box Border
			Console.Write (newline + Space3 + TL);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}			
			Console.Write (TR);

			//Content - Line 1
			Console.Write (newline + Space3 + Vert + line1 + Vert);

			//Separator Border
			boxParts.customSub(line1);

			//Content - Line 2
			Console.Write(newline + Space3 + Vert + line2);
			spacer.customSpace (line1, line2);
			Console.Write (Vert);

			//Bottom Border
			length1 = line1.Length;
			Console.Write (newline + Space3 + BL);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}			
			Console.Write (BR);

		} else if (length2 > length1) {
			length1 = line1.Length;
			length2 = line2.Length;

			//Top Box Border
			Console.Write (newline + Space3 + TL);
			while (length2 > 0) {
				Console.Write (heading);
				length2 -= 1;
			}			
			Console.Write (TR);

			//Content - Line 1
			Console.Write(newline + Space3 + Vert + line1);
			spacer.customSpace (line2, line1);
			Console.Write (Vert);

			//Separator Border
			boxParts.customSub(line2);

			//Content - Line 2
			Console.Write (newline + Space3 + Vert + line2 + Vert);

			//Bottom Border
			length2 = line2.Length;
			Console.Write (newline + Space3 + BL);
			while (length2 > 0) {
				Console.Write (heading);
				length2 -= 1;
			}			
			Console.Write (BR);
		} else {
			Console.Write ("Issues");
		}
	}
}


