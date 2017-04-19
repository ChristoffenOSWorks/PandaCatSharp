using System;
using System.Collections;
using System.Collections.Generic;

namespace PandaCat {
	public class TextBoxes : StrLenFind {
		public BoxParts boxParts = new BoxParts();
		public StrLenFind spacer = new StrLenFind();		

		public void CustomBox1(String line1) {
			length1 = line1.Length;
			Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][3]);
			while (length1 > 0) {
				Console.Write (Text.text[3][0]);
				length1 -= 1;
			}			
			Console.Write (Text.text[3][4]);

			Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line1 + Text.text[3][1]);

			length1 = line1.Length;
			Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][5]);
			while (length1 > 0) {
				Console.Write (Text.text[3][0]);
				length1 -= 1;
			}			
			Console.Write (Text.text[3][6]);

		}

		public void CustomBox2(String line1, String line2) {
			length1 = line1.Length;
			length2 = line2.Length;

			if (length1 > length2) {
				//Top Box Border
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][3]);
				while (length1 > 0) {
					Console.Write (Text.text[3][0]);
					length1 -= 1;
				}			
				Console.Write (Text.text[3][4]);

				//Content - Line 1
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line1 + Text.text[3][1]);

				//Separator Border
				boxParts.customSub(line1);

				//Content - Line 2
				Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line2);
				spacer.customSpace1 (line1, line2);
				Console.Write (Text.text[3][1]);

				//Bottom Border
				length1 = line1.Length;
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][5]);
				while (length1 > 0) {
					Console.Write (Text.text[3][0]);
					length1 -= 1;
				}			
				Console.Write (Text.text[3][6]);

			} else if (length2 > length1) {
				length1 = line1.Length;
				length2 = line2.Length;

				//Top Box Border
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][3]);
				while (length2 > 0) {
					Console.Write (Text.text[3][0]);
					length2 -= 1;
				}			
				Console.Write (Text.text[3][4]);

				//Content - Line 1
				Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line1);
				spacer.customSpace1 (line2, line1);
				Console.Write (Text.text[3][1]);

				//Separator Border
				boxParts.customSub(line2);

				//Content - Line 2
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line2 + Text.text[3][1]);

				//Bottom Border
				length2 = line2.Length;
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][5]);
				while (length2 > 0) {
					Console.Write (Text.text[3][0]);
					length2 -= 1;
				}			
				Console.Write (Text.text[3][6]);
			} else {
				Console.Write ("");
			}
		}

		public void CustomBox3(String line1, String line2, String line3) {
			length1 = line1.Length;
			length2 = line2.Length;
			length3 = line3.Length;

			if ((length1 > length2) && (length1 > length3)) {

				//Top Box Border
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][3]);
				while (length1 > 0) {
					Console.Write (Text.text[3][0]);
					length1 -= 1;
				}			
				Console.Write (Text.text[3][4]);

				//Content - Line 1
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line1 + Text.text[3][1]);

				//Separator Border 1
				boxParts.customSub (line1);

				//Content - Line 2
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line2);
				spacer.customSpace1 (line1, line2);
				Console.Write (Text.text[3][1]);

				//Separator Border 2
				boxParts.customSub (line1);

				//Content - Line 3
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line3);
				spacer.customSpace1 (line1, line3);
				Console.Write (Text.text[3][1]);

				//Bottom Border
				length1 = line1.Length;
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][5]);
				while (length1 > 0) {
					Console.Write (Text.text[3][0]);
					length1 -= 1;
				}			
				Console.Write (Text.text[3][6]);

			} else if ((length2 > length1) && (length2 > length3)) {

				length1 = line1.Length;
				length2 = line2.Length;
				length3 = line3.Length;

				//Top Box Border
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][3]);
				while (length2 > 0) {
					Console.Write (Text.text[3][0]);
					length2 -= 1;
				}			
				Console.Write (Text.text[3][4]);

				//Content - Line 1
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line1);
				spacer.customSpace1 (line2, line1);
				Console.Write (Text.text[3][1]);

				//Separator Border
				boxParts.customSub (line2);

				//Content - Line 2
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line2 + Text.text[3][1]);

				//Separator Border 2
				boxParts.customSub (line2);

				//Content - Line 3
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line3);
				spacer.customSpace1 (line2, line3);
				Console.Write (Text.text[3][1]);

				//Bottom Border
				length2 = line2.Length;
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][5]);
				while (length2 > 0) {
					Console.Write (Text.text[3][0]);
					length2 -= 1;
				}			
				Console.Write (Text.text[3][6]);

			} else if ((length3 > length1) && (length3 > length2)) {

				length1 = line1.Length;
				length2 = line2.Length;
				length3 = line3.Length;

				//Top Box Border
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][3]);
				while (length3 > 0) {
					Console.Write (Text.text[3][0]);
					length3 -= 1;
				}			
				Console.Write (Text.text[3][4]);

				//Content - Line 1
				Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line1);
				spacer.customSpace1 (line3, line1);
				Console.Write (Text.text[3][1]);

				//Separator Border
				boxParts.customSub(line3);

				//Content - Line 2
				Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line2);
				spacer.customSpace1 (line3, line2);
				Console.Write (Text.text[3][1]);

				//Separator Border 2
				boxParts.customSub (line3);

				//Content - Line 3
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][2] + line3 + Text.text[3][1]);

				//Bottom Border
				length3 = line3.Length;
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[3][5]);
				while (length3 > 0) {
					Console.Write (Text.text[3][0]);
					length3 -= 1;
				}			
				Console.Write (Text.text[3][6]);

			} else {

				Console.Write ("");

			}

		}

	}
}

