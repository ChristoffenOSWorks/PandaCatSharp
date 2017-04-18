using System;
using System.IO;

namespace PandaCat {
	public class ImageNameLoop {
		public int imgs;
		private String number;

		public void ImageLoop() {
			TextBoxes textBox = new TextBoxes();
			textBox.CustomBox2 (Text.text[1][0], Text.text[1][1]);
			textBox.CustomBox3(Text.text[13][0], Text.text[13][1], Text.text[13][2]);
			Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
			number = Console.ReadLine();
			imgs = int.Parse(number);

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
		}

		public void ImageName() {
			using (StreamWriter write = File.AppendText(Files.filename + ".c")) {
				write.WriteLine(Text.text[4][3] + Text.text[0][0] + Text.text[11][11] + Text.text[4][2] + Files.filename + ".png" + Text.text[4][2] + Text.text[4][4]);
			}
		}
	}
}
