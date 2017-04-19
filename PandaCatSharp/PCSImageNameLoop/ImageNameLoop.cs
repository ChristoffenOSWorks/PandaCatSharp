using System;
using System.IO;

namespace PandaCat {
	public class ImageNameLoop {
		public bool imgs;
		public int imgs1;

		public void ImageLoop() {
			while (!imgs) {
				TextBoxes textBox = new TextBoxes();

				textBox.CustomBox2 (Text.text[1][0], Text.text[1][1]);
				textBox.CustomBox3(Text.text[13][0], Text.text[13][1], Text.text[13][2]);
				Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);

				imgs = int.TryParse(Console.ReadLine(), out imgs1);

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
			}
		}

		public void ImageName() {
			using (StreamWriter write = File.AppendText(Files.filename + ".c")) {
				write.WriteLine(Text.text[4][3] + Text.text[0][0] + Text.text[11][11] + Text.text[4][2] + Files.filename + ".png" + Text.text[4][2] + Text.text[4][4]);
			}
		}
	}
}
