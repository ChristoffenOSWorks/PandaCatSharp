using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PandaCat {
	public class Resolution : Tabby {

		public String[] hw = new String[2];
		public void dimensions() {
			int width;
			int height;
			//String input;
			String io;

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.Clear();
			TextBoxes textBox = new TextBoxes();

			textBox.CustomBox2(Text.text[12][0], Text.text[12][1]);

			textBox.CustomBox1(Text.text[12][2]);
			Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
			hw[0] = Console.ReadLine();
			io = hw[0];
			width = int.Parse(io);

			textBox.CustomBox1(Text.text[12][3]);
			Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
			hw[1] = Console.ReadLine();
			io = hw[1];
			height = int.Parse(io);

			using (StreamWriter w = File.AppendText(filename + ".c")) {
				Template.LogLine(Text.text[11][6] + width + Text.text[4][1] + height + Text.text[4][4], w);
			}
		}
	}
}
