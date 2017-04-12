using System;
using System.Collections;
using System.Collections.Generic;

namespace PandaCat {
	public class BoxParts : Tabby {
			
		public void subheading1() {
			length1 = Text.text[1][2].Length;
			Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][3]);
			while (length1 > 0) {
				Console.Write (Text.text[3][9]);
				length1 -= 1;
			}
			Console.Write (Text.text[3][8]);
		}

		public void customSub(String custom1) {
			int length0 = custom1.Length;
			Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2]);
			while (length0 > 0) {
				Console.Write (Text.text[3][9]);
				length0 -= 1;
			}
			Console.Write (Text.text[3][1]);
		}

		public void subHead() {
			Console.Write (Text.text[0][2] + Text.text[3][7]);
			subheading1 ();
			Console.Write (Text.text[3][8]);
		}
	}
}

