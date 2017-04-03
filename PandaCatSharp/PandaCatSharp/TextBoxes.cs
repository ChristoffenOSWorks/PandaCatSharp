using System;
using System.Collections;
using System.Collections.Generic;

	public class TextBoxes : PandaCat {
		public BoxParts boxParts = new BoxParts();
		public StrLenFind spacer = new StrLenFind();
		
		public void convertBoxR() {
			boxParts.convertHeadingTop ();
			Console.Write (newline + Space3 + Vert + Step1); 
			spacer.convertSpace ();
			Console.Write(Vert);
			boxParts.convertSubheading ();
			Console.Write (newline + Space3 + Vert + convertR + Vert);
			boxParts.convertHeadingBottom ();
		}

		public void convertBoxG() {
			boxParts.convertHeadingTop ();
			Console.Write (newline + Space3 + Vert + Step2); 
			spacer.convertSpace ();
			Console.Write(Vert);
			boxParts.convertSubheading ();
			Console.Write (newline + Space3 + Vert + convertG + Vert);
			boxParts.convertHeadingBottom ();
		}

		public void convertBoxB() {
			boxParts.convertHeadingTop ();
			Console.Write (newline + Space3 + Vert + Step3); 
			spacer.convertSpace ();
			Console.Write(Vert);
			boxParts.convertSubheading ();
			Console.Write (newline + Space3 + Vert + convertB + Vert);
			boxParts.convertHeadingBottom ();
		}

		public void convertRDone(String answer) {
			boxParts.convertHeadingTop ();
			Console.Write (newline + Space3 + Vert + Step1C);
			spacer.convertSpaceC ();
			Console.Write (Vert);
			boxParts.convertSubheading ();
			Console.Write (newline + Space3 + Vert + yourAnswer + answer);
			
			length1 = convertR.Length;
			length2 = yourAnswer.Length + answer.Length;
			while (length1 > length2) {
				Console.Write (" ");
				length2 += 1;
			} 

			Console.Write (Vert);
			boxParts.convertHeadingBottom ();
		}

		public void convertGDone(String answer) {
			boxParts.convertHeadingTop ();
			Console.Write (newline + Space3 + Vert + Step2C);
			spacer.convertSpaceC ();
			Console.Write (Vert);
			boxParts.convertSubheading ();
			Console.Write (newline + Space3 + Vert + yourAnswer + answer);

			length1 = convertR.Length;
			length2 = yourAnswer.Length + answer.Length;
			while (length1 > length2) {
				Console.Write (" ");
				length2 += 1;
			} 
			
			Console.Write (Vert);
			boxParts.convertHeadingBottom ();
		}

		public void convertBDone(String answer) {
			boxParts.convertHeadingTop ();
			Console.Write (newline + Space3 + Vert + Step3C);
			spacer.convertSpaceC ();
			Console.Write (Vert);
			boxParts.convertSubheading ();
			Console.Write (newline + Space3 + Vert + yourAnswer + answer);

			length1 = convertR.Length;
			length2 = yourAnswer.Length + answer.Length;
			while (length1 > length2) {
				Console.Write (" ");
				length2 += 1;
			} 

			Console.Write (Vert);
			boxParts.convertHeadingBottom ();
		}


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
	}


