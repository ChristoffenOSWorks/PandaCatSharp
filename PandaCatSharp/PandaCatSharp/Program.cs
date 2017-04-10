﻿using System;
using System.Collections.Generic;
using System.IO;

namespace PandaCat {
	public class Tabby {
		public static String filename;
		public Text t = new Text ();
//		public String Text.text[2][4] = "Text.text[2][4] Cairo, the original RGB values are: "; 
		public String setSourceRGBAStart = "cairo_set_source_rgba(cr, ";
		public String toCairoEnd = ", 0.8);";
		public String exit = "Press ENTER key to exit";

		public static int length1;
		public static int length2;
		public static int length3;

		public String rgb1 = "This is the Cairo-RGB color converter";
		public String rgb2 = "When you're done, hit enter to move to the next screen.";

		public String result2 = "Your values have been converted from Cairo C API to standard RGB:";

		public String yourAnswer = "Your answer was: ";

		public String result1 = "You can now paste the following function to a Cairo C application";
		public static String file;	
		public static String filedesc1 = "This application will write C files to the folder it is run in.";
		public static String filedesc2 = "C files are generated here using the Cairo API, so you don't have to write them.";
		public static String filedesc3 = "So, what would you like to name the new C file generated this run?";

		public String ltIntro = "Now for the LineTo() generator, which also generates a Cairo C function.";
		public String xval = "Please enter the X value to plot.";
		public String yval = "Please enter the Y value to plat.";

		public static void empty(String variable) {
			TextBoxes textBox = new TextBoxes ();

			if (String.IsNullOrEmpty (variable)) {

				while (String.IsNullOrEmpty (variable)) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.Clear ();

					textBox.CustomBox1 (Text.text[0][2] + "If this is Elijah, it is an ID10T error. let's try this again.");
					variable = Console.ReadLine ();

					continue;
				} 
			}
		}
			
		public static void Main (string[] args) {

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();

			TextBoxes textBox = new TextBoxes ();
			textBox.CustomBox3 (filedesc1, filedesc2, filedesc3);
			Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
			filename = Console.ReadLine ();
			if (String.IsNullOrEmpty (filename)) {
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();

				while (String.IsNullOrEmpty (filename)) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.Clear ();

					textBox.CustomBox1 ("If this is Elijah, it is an ID10T error. let's try this again.");
					textBox.CustomBox3 ("Everyone else using PandaCat (#LowlyAssistant):", "This error appears when nothing has been entered. Type something, ", "and you can move forward.");

					Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
					filename = Console.ReadLine ();

					continue;
				} 

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			}	
			file = filename;

			//Text t = new Text ();

			if (String.IsNullOrEmpty (filename)) {
				Console.Clear ();
				Console.WriteLine ("FAILURE");
			}

			using (StreamWriter write = File.AppendText (file + ".c")) {
				write.WriteLine ("#include" + Text.text[4][3]);
			}

			PandaCat.Colors.userChoice converter = new PandaCat.Colors.userChoice();
			converter.choice ();

			//Console.WriteLine (Text.text[4][3] + "Press ENTER key to exit");
			Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
			Console.ReadLine ();

			LineTo lineTo = new LineTo ();
			lineTo.Logic ();
		}
	}
}

