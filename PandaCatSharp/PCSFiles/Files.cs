using System;
using System.Collections.Generic;
using System.IO;

namespace PandaCat {
	public class Files {
		public static String filename;
		public Text t = new Text ();
		public static String file;	

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
			textBox.CustomBox2 (Text.text[1][0], Text.text[1][1]);
			textBox.CustomBox3 (Text.text[9][0], Text.text[9][1], Text.text[9][2]);

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
	}
}
