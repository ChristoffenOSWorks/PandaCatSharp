using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PandaCat {
	public class LineTo {
		TextBoxes textBox = new TextBoxes ();

		private String x1;
		private float x2;
		private String x3;

		private String y1;
		private float y2;
		private String y3;

		public void Logic() {
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.Clear ();
			textBox.CustomBox1("Enter number of points to plot");
			Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");

			String loop = Console.ReadLine();
			String loop1 = loop;
			int loop2 = int.Parse (loop1);
			int adder = 0;
			int step_io = 1;
			int step_progress = 1;

			while (loop2 > adder) {
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear ();
				textBox.CustomBox1 (Text.text[10][0]);

				textBox.CustomBox2 ("Step " + step_io.ToString() + " - In Progress!", Text.text[10][1]);
				step_io += 1;
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
				String x = Console.ReadLine ();
				x1 = x;
				x2 = float.Parse (x1);
				x3 = x2.ToString ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear ();
				textBox.CustomBox1 (Text.text[10][0]);
				textBox.CustomBox2 ("Step " + step_progress.ToString() + " - Complete!", Text.text[8][2] + x3);
				step_progress += 1;

				textBox.CustomBox2 ("Step " + step_io.ToString() + " - In Progress!", Text.text[10][2]);
				step_io += 1;
				Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
				String y = Console.ReadLine ();
				y1 = y;
				y2 = float.Parse (y1);
				y3 = y2.ToString ();
	//			textBox.CustomBox2 ("Step " + step_progress.ToString() + " - Complete!", yourAnswer + y3);
	//			step_progress += 1;

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Clear ();
				textBox.CustomBox1 (Text.text[10][0]);
				int back1 = step_progress;
				int back2 = back1 - 1;
				textBox.CustomBox2 ("Step " + back2.ToString() + " - Complete!", Text.text[8][2] + x3);
				textBox.CustomBox2 ("Step " + step_progress.ToString() + " - Complete!", Text.text[8][2] + y3);
				step_progress += 1;

				int loop3 = loop2;
				int loop4 = loop3 * 2;

				int exitAt = 2;
				exitAt += 1;
				if (exitAt < loop4) {
					textBox.CustomBox1 ("Press ENTER to continue.");
					Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
					Console.ReadLine ();
				} else {
					textBox.CustomBox1 ("Press ENTER to exit.");
					Console.Write (Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
					Console.ReadLine ();
				}

				using (StreamWriter write = File.AppendText (Files.file + ".c")) {
					write.WriteLine ("cairo_line_to(cr, " + x3 + Text.text[4][1] + y3 + ");");
				}

				loop2 -= 1;
			}
		}
	}
}

