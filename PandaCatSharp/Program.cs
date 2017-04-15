/**
 * The main file - PandaCat
 * 
 * This file contains a ton of stuff, and needs 
 * to be cleaned up.
 * 
 * Credits: Written by M. Gage Morgan, some venue 
 * provided by Mark Suter. Written for Elijah Clark 
 * to make it possible to easily develop Cairo C applications.
 * 
 **/
using System;
using System.Collections.Generic;
using System.IO;

namespace PandaCat {
	public class Tabby {
		public Text t = new Text ();

		public static LineTo lineto = new LineTo();

		/**
		 * Main function. All command line parameters go here.
		 **/
		public static void Main (string[] args) {

			try {
				String LineTo = "--LineTo";
				if (args[0] == LineTo) {
					Console.Write("LineTo is detected");
					lineto.Logic ();
				} else if (args[0] == "--ToRGB") {
					Files.Filename();
					Colors.ToRGB toRGB = new PandaCat.Colors.ToRGB();
					toRGB.toRGB(); 
				} else if (args[0] == "--ToCairo") {
					Files.Filename();
					Cairo toCairo = new Cairo();
					toCairo.toCairo();
				} else if (args[0] == "--help") {
					Console.WriteLine("PandaCat Cairo API Generator");
					Console.WriteLine("--LineTo  Starts at function Logic()");
					Console.ReadLine();
				} else {
					Console.WriteLine("Nothingness");
				}

			} catch {
				Console.Write ("Nothing entered");
			} finally {
				Console.Write ("Something wrong?");
			}

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
			History hist = new History();
			hist.history1();

			PandaCat.Colors.userChoice converter = new PandaCat.Colors.userChoice();
			converter.choice ();

			lineto.Logic();

			Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");

			Console.ReadLine ();
		}
	}
}

