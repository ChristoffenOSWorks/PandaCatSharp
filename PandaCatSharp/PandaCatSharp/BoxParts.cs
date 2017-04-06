using System;
using System.Collections;
using System.Collections.Generic;

namespace PandaCat {
	public class BoxParts : Tabby {
			
		public void subheading1() {
			length1 = copyright[2].Length;
			Console.Write (newline + spaces[2] + LW);
			while (length1 > 0) {
				Console.Write (subheading);
				length1 -= 1;
			}
			Console.Write (RW);
		}

		public void convertSubheading() {
			length1 = convertRGB[1].Length;
			Console.Write (newline + spaces[2] + LW);
			while (length1 > 0) {
				Console.Write (subheading);
				length1 -= 1;
			}
			Console.Write (RW);
		}

		public void customSub(String custom1) {
			int length0 = custom1.Length;
			Console.Write (newline + spaces[2] + Vert1);
			while (length0 > 0) {
				Console.Write (subheading);
				length0 -= 1;
			}
			Console.Write (Vert2);
		}


		public void convertHeadingTop() {
			length1 = convertRGB[1].Length;
			Console.Write (newline + spaces[2] + TL);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}			
			Console.Write (TR);
		}

		public void convertHeadingBottom() {
			length1 = convertRGB[1].Length;
			Console.Write (newline + spaces[2] + BL);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}	
			Console.Write (BR);
		}

		public void head2() {
			length1 = result1.Length;
			Console.Write (spaces[2]);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}
		}

		public void subheading2() {
			length1 = result1.Length;
			Console.Write (spaces[2]);
			while (length1 > 0) {
				Console.Write (subheading);
				length1 -= 1;
			}
		}

		public void head1FullTop() {
			length1 = copyright[2].Length;
			Console.Write (newline + spaces[2] + TL);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}			
			Console.Write (TR);
		}

		public void head1FullBottom() {
			length1 = copyright[2].Length;
			Console.Write (newline + spaces[2] + BL);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}	
			Console.Write (BR);
		}

		public void subHead() {
			Console.Write (spaces[2] + LW);
			subheading1 ();
			Console.Write (RW);
		}
	}
}

