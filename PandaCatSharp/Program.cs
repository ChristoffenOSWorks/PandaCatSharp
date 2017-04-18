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
		public static int i = 1;

		public static void Main (string[] args) {
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();

			ImageNameLoop image = new ImageNameLoop();
			image.ImageLoop();

			while (i <= image.imgs) {
				Cadence.Order();
				i++;
			}
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();

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
			}
		}
	}
}

