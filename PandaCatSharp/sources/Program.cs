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
		public static String filename;
		public Text t = new Text ();

		/**
		 * TODO: Add to the Text jagged array
		 **/
		public String setSourceRGBAStart = "cairo_set_source_rgba(cr, ";
		public String toCairoEnd = ", 0.8);";
		public String exit = "Press ENTER key to exit";

		/** TODO: Create a new jagged array containing 
		 * ints like these.
		 **/
		public static int length1;
		public static int length2;
		public static int length3;

		/**
		 * TODO: Add to the Text jagged array
		 **/
		public String rgb1 = "This is the Cairo-RGB color converter";
		public String rgb2 = "When you're done, hit enter to move to the next screen.";

		/**
		 * TODO: Add to the Text jagged array
		 **/
		public String result2 = "Your values have been converted from Cairo C API to standard RGB:";

		/**
		 * TODO: Add to the Text jagged array
		 **/
		public String yourAnswer = "Your answer was: ";

		/**
		 * TODO: Add to the Text jagged array
		 **/
		public String result1 = "You can now paste the following function to a Cairo C application";
	
		/**
		 * This cannot be moved outside this file. 
		 * It contains whatever was entered in ReadLine 
		 * for filename.
		 **/
		public static String file;	

		/**
		 * TODO: Add to the Text jagged array
		 **/
		public static String filedesc1 = "This application will write C files to the folder it is run in.";
		public static String filedesc2 = "C files are generated here using the Cairo API, so you don't have to write them.";
		public static String filedesc3 = "So, what would you like to name the new C file generated this run?";

		/**
		 * TODO: Add to the Text jagged array
		 **/
		public String ltIntro = "Now for the LineTo() generator, which also generates a Cairo C function.";
		public String xval = "Please enter the X value to plot.";
		public String yval = "Please enter the Y value to plat.";

		public static void Filename() {
			/**
			 * Create object "textBox." This creates a reference 
			 * to a class TextBoxes, which contains functions 
			 * that do heavy lifting for creating "fancy" boxes
			 * in the console, as can be seen when you run this 
			 * project compiled.
			 **/
			PandaCat.TextBoxes textBox = new PandaCat.TextBoxes ();

			/**
			 * Creates a box with instructions for the user to 
			 * input a filename to be generated.
			 **/
			textBox.CustomBox3 (filedesc1, filedesc2, filedesc3);

			/**
			 * Creates (on a new line) a "terminal bell." 
			 **/
			Console.Write (Text.text [4] [3] + Text.text [0] [2] + ">> ");

			/** 
			 * Set the variable "filename" to get user input.
			 * This will be used for file creation.
			 **/
			filename = Console.ReadLine ();

			/** 
			 * If you hit enter without typing anything into 
			 * the filename variable, get burnt
			 **/
			if (String.IsNullOrEmpty (filename)) {

				/**
				 * The following block tells the program
				 * to set the text in the text color to white,
				 * and subsequently set the background to a 
				 * dark cyan-ish color.
				 **/
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();

				/**
				 * Here's what the program will do in the duration 
				 * of that filename being blank.
				 **/
				while (String.IsNullOrEmpty (filename)) {

					/**
					 * The following block tells the program
					 * to set the text in the text color to red,
					 * and subsequently set the background to a 
					 * dark-grey-ish color.
					 **/
					Console.ForegroundColor = ConsoleColor.Red;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.Clear ();

					/**
					 * This CustomBox1() is basically a joke, used 
					 * internally. Displays the joke on-screen.
					 **/
					textBox.CustomBox1 ("If this is Elijah, it is an ID10T error. let's try this again.");

					/**
					 * This CustomBox3() has 3 lines, and explains 
					 * in more detail why the error happened for all 
					 * the "normals" reading it.
					 **/
					textBox.CustomBox3 ("Everyone else using PandaCat (#LowlyAssistant):", "This error appears when nothing has been entered. Type something, ", "and you can move forward.");

					/**
					 * Creates (on a new line) a "terminal bell." 
			 		 **/
					Console.Write (Text.text [4] [3] + Text.text [0] [2] + ">> ");

					/**
					 * Set filename equal to user input. 
					 * The input will create a file with a name of 
					 * whatever the user typed.
					 */
					filename = Console.ReadLine ();

					/**
					 * NOW go forward with the app.
					 **/
					continue;
				} 

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
			}	
			file = filename;

			if (String.IsNullOrEmpty (filename)) {
				Console.Clear ();
				Console.WriteLine ("FAILURE");
			}
		}

		/**
		 * Main function. All command line parameters go here.
		 * 
		 * TODO: Adding breakpoints for individual pieces of 
		 * program soon.
		 **/
		public static void Main (string[] args) {

			try {
				String LineTo = "--LineTo";
				if (args[0] == LineTo) {
					Console.Write("LineTo is detected");
					LineTo lineto = new LineTo ();
					lineto.Logic ();
				} else if (args[0] == "--ToRGB") {
					Filename();
					Colors.ToRGB toRGB = new PandaCat.Colors.ToRGB();
					toRGB.toRGB(); 
				} else if (args[0] == "--ToCairo") {
					Filename();
					Colors.Cairo toCairo = new Colors.Cairo();
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

			using (StreamWriter write = File.AppendText (file + ".c")) {
				write.WriteLine ("#include" + Text.text[4][3]);
			}

			Filename ();

			PandaCat.Colors.userChoice converter = new PandaCat.Colors.userChoice();
			converter.choice ();

			//Console.WriteLine (Text.text[4][3] + "Press ENTER key to exit");

			Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
			Console.ReadLine ();
		}
	}
}

