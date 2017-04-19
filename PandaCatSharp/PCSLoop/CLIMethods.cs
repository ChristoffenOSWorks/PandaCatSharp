using System;
namespace PandaCat {
	
	public class CLIMethods {
		public static int i = 1;

		public static void MainLoop() {
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
		}

		public static void LineTo() {
			Console.Write("LineTo is detected");
			LineTo lineto = new LineTo();
			lineto.Logic ();
			Environment.Exit(0);
		}

		public static void ToRGB() {
			Files.Filename();
			Colors.ToRGB toRGB = new PandaCat.Colors.ToRGB();
			toRGB.toRGB(); 
			Environment.Exit(0);
		}

		public static Cairo toCairo = new Cairo();

		public static void ToCairo() {
			Files.Filename();
			toCairo.toCairo();
			Environment.Exit(0);
		}

		public static void ToCairoRSet() {
			toCairo.toCairo_R_set();
		}

		public static void HLBling() {
			Console.WriteLine("PandaCat Cairo API Generator");
			Console.WriteLine("--LineTo  Starts at function Logic()");
			Environment.Exit(0);
		}
	}
}
