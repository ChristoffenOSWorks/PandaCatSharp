using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PandaCat {
	public class Resolution {

		public static String[] hw = new String[2];
		public void dimensions() {
			bool width = false;
			bool height = false;
			//String input;
			int io1;
			int io2;

			TextBoxes textBox = new TextBoxes();

			while (!width) {
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkGreen;
				Console.Clear();
				textBox.CustomBox2(Text.text[12][0], Text.text[12][1]);
				textBox.CustomBox2("Step 1 - In Progress!", Text.text[12][2]);

				Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
				width = int.TryParse(Console.ReadLine(), out io1);
				hw[0] = io1.ToString();
			}

			while (!height) {
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkGreen;
				Console.Clear();
				textBox.CustomBox2(Text.text[12][0], Text.text[12][1]);
				textBox.CustomBox2("Step 1 - Complete!", "Your answer was: " + hw[0]);
				textBox.CustomBox2("Step 2 - In Progress!", Text.text[12][3]);

				Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
				height = int.TryParse(Console.ReadLine(), out io2);
				hw[1] = io2.ToString();
			}

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.Clear();
			textBox.CustomBox2(Text.text[12][0], Text.text[12][1]);
			textBox.CustomBox2("Step 1 - Complete!", "Your answer was: " + hw[0]);
			textBox.CustomBox2("Step 1 - Complete!", "Your answer was: " + hw[1]);
			textBox.CustomBox1("Press ENTER to exit");
			Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
			Console.ReadLine();

			using (StreamWriter w = File.AppendText(Files.filename + ".c")) {
				Template.LogLine(Text.text[0][1] + Text.text[11][6] + hw[0] + Text.text[4][1] + hw[1] + Text.text[4][4], w);
			}
		}
	}
}
