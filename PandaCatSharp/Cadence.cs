using System;
using System.IO;

namespace PandaCat {
	public class Cadence {
		public static void Order() {
			/**
			 * The following block tells the program
			 * to set the text in the text color to white,
			 * and subsequently set the background to a 
			 * dark cyan-ish color.
			 **/

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();

			using (StreamWriter write = File.AppendText (Files.file + ".c")) {
				write.WriteLine ("#include" + Text.text[4][3]);
			}

			Files.Filename ();

			Template ctext = new Template();
			ctext.Part1();

			Resolution dimensions = new Resolution();
			dimensions.dimensions();

			Template ctext2 = new Template();
			ctext2.Part2();

			PandaCat.Colors.userChoice converter = new PandaCat.Colors.userChoice();
			converter.choice ();

			History hist = new History();
			hist.history3();
			Console.Write(Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
			Console.ReadLine();

			LineTo lineto = new LineTo();
			lineto.Logic();
		}
	}
}
