using System;
using System.Collections;
using System.Collections.Generic;

namespace PandaCat {
	public class TextBoxes : Tabby {
		public BoxParts boxParts = new BoxParts();
		public StrLenFind spacer = new StrLenFind();		

		public void CustomBox1(String line1) {
			length1 = line1.Length;
			Console.Write (newline + spaces[2] + TL);
			while (length1 > 0) {
				Console.Write (heading);
				length1 -= 1;
			}			
			Console.Write (TR);

			Console.Write (newline + spaces[2] + Vert1 + line1 + Vert2);

			length1 = line1.Length;
			Console.Write (newline + spaces[2] + BL);
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
				Console.Write (newline + spaces[2] + TL);
				while (length1 > 0) {
					Console.Write (heading);
					length1 -= 1;
				}			
				Console.Write (TR);

				//Content - Line 1
				Console.Write (newline + spaces[2] + Vert1 + line1 + Vert2);

				//Separator Border
				boxParts.customSub(line1);

				//Content - Line 2
				Console.Write(newline + spaces[2] + Vert1 + line2);
				spacer.customSpace1 (line1, line2);
				Console.Write (Vert2);

				//Bottom Border
				length1 = line1.Length;
				Console.Write (newline + spaces[2] + BL);
				while (length1 > 0) {
					Console.Write (heading);
					length1 -= 1;
				}			
				Console.Write (BR);

			} else if (length2 > length1) {
				length1 = line1.Length;
				length2 = line2.Length;

				//Top Box Border
				Console.Write (newline + spaces[2] + TL);
				while (length2 > 0) {
					Console.Write (heading);
					length2 -= 1;
				}			
				Console.Write (TR);

				//Content - Line 1
				Console.Write(newline + spaces[2] + Vert1 + line1);
				spacer.customSpace1 (line2, line1);
				Console.Write (Vert2);

				//Separator Border
				boxParts.customSub(line2);

				//Content - Line 2
				Console.Write (newline + spaces[2] + Vert1 + line2 + Vert2);

				//Bottom Border
				length2 = line2.Length;
				Console.Write (newline + spaces[2] + BL);
				while (length2 > 0) {
					Console.Write (heading);
					length2 -= 1;
				}			
				Console.Write (BR);
			} else {
				Console.Write ("Issues");
			}
		}

		public void CustomBox3(String line1, String line2, String line3) {
			length1 = line1.Length;
			length2 = line2.Length;
			length3 = line3.Length;

			if ((length1 > length2) && (length1 > length3)) {
				
				//Top Box Border
				Console.Write (newline + spaces[2] + TL);
				while (length1 > 0) {
					Console.Write (heading);
					length1 -= 1;
				}			
				Console.Write (TR);

				//Content - Line 1
				Console.Write (newline + spaces[2] + Vert1 + line1 + Vert2);

				//Separator Border 1
				boxParts.customSub (line1);

				//Content - Line 2
				Console.Write (newline + spaces[2] + Vert1 + line2);
				spacer.customSpace1 (line1, line2);
				Console.Write (Vert2);

				//Separator Border 2
				boxParts.customSub (line1);

				//Content - Line 3
				Console.Write (newline + spaces[2] + Vert1 + line3);
				spacer.customSpace1 (line1, line3);
				Console.Write (Vert2);

				//Bottom Border
				length1 = line1.Length;
				Console.Write (newline + spaces[2] + BL);
				while (length1 > 0) {
					Console.Write (heading);
					length1 -= 1;
				}			
				Console.Write (BR);

			} else if ((length2 > length1) && (length2 > length3)) {
				
				length1 = line1.Length;
				length2 = line2.Length;
				length3 = line3.Length;

				//Top Box Border
				Console.Write (newline + spaces[2] + TL);
				while (length2 > 0) {
					Console.Write (heading);
					length2 -= 1;
				}			
				Console.Write (TR);

				//Content - Line 1
				Console.Write (newline + spaces[2] + Vert1 + line1);
				spacer.customSpace1 (line2, line1);
				Console.Write (Vert2);

				//Separator Border
				boxParts.customSub (line2);

				//Content - Line 2
				Console.Write (newline + spaces[2] + Vert1 + line2 + Vert2);

				//Separator Border 2
				boxParts.customSub (line2);

				//Content - Line 3
				Console.Write (newline + spaces[2] + Vert1 + line3);
				spacer.customSpace1 (line2, line3);
				Console.Write (Vert2);

				//Bottom Border
				length2 = line2.Length;
				Console.Write (newline + spaces[2] + BL);
				while (length2 > 0) {
					Console.Write (heading);
					length2 -= 1;
				}			
				Console.Write (BR);

			} else if ((length3 > length1) && (length3 > length2)) {
				
				length1 = line1.Length;
				length2 = line2.Length;
				length3 = line3.Length;

				//Top Box Border
				Console.Write (newline + spaces[2] + TL);
				while (length3 > 0) {
					Console.Write (heading);
					length3 -= 1;
				}			
				Console.Write (TR);

				//Content - Line 1
				Console.Write(newline + spaces[2] + Vert1 + line1);
				spacer.customSpace1 (line3, line1);
				Console.Write (Vert2);

				//Separator Border
				boxParts.customSub(line3);

				//Content - Line 2
				Console.Write(newline + spaces[2] + Vert1 + line2);
				spacer.customSpace1 (line3, line2);
				Console.Write (Vert2);

				//Separator Border 2
				boxParts.customSub (line3);

				//Content - Line 3
				Console.Write (newline + spaces[2] + Vert1 + line3 + Vert2);

				//Bottom Border
				length3 = line3.Length;
				Console.Write (newline + spaces[2] + BL);
				while (length3 > 0) {
					Console.Write (heading);
					length3 -= 1;
				}			
				Console.Write (BR);

			} else {

				Console.Write ("Issues");
			
			}
		}
	}
}

