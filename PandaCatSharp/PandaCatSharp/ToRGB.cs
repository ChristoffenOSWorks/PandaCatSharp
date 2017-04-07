using System;
using PandaCat;
using PandaCat.Colors;

namespace PandaCat {
	namespace Colors {
		public class ToRGB : Tabby {
			public TextBoxes textBox = new TextBoxes();
			public StrLenFind spacer = new StrLenFind ();

			private String r;
			private String g;
			private String b;

			private String r0;
			public float r1;
			public float r2;
			public double r3;
			public String r4;

			private String g0;
			private float g1;
			private float g2;
			private double g3;
			private String g4;

			private String b0;
			private float b1;
			private float b2;
			private double b3;
			private String b4;

			public void toRGB_R_set() {
				r = Console.ReadLine();
				r0 = r;
				r1 = float.Parse(r0);
				r2 = r1 * 255;
				r3 = Math.Round (r2); 
				r4 = r3.ToString ();
			}

			public void toRGB_G_set() {
				g = Console.ReadLine ();
				g0 = g;
				g1 = float.Parse (g0);
				g2 = g1 * 255;
				g3 = Math.Round (g2); 
				g4 = g3.ToString ();
			}

			public void toRGB_B_set() {
				b = Console.ReadLine ();
				b0 = b;
				b1 = float.Parse (b0);
				b2 = b1 * 255;
				b3 = Math.Round (b2); 
				b4 = b3.ToString ();
			}

			public void toRGB_R() {
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox1("Writing to: " + file + ".c");
				textBox.CustomBox2 (rgb1, rgb2);

				textBox.CustomBox2 (Step1, text[2][1]);
				Console.Write (text[4][3] + text[0][2] + ">> ");

				toRGB_R_set ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Step1C, yourAnswer + r0);
			}

			public void toRGB_G () {
				Console.WriteLine (text[0][2]);
				textBox.CustomBox2 (Step2, text[2][2]);
				Console.Write (text[4][3] + text[0][2] + ">> ");

				toRGB_G_set ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Step1C, yourAnswer + r0);
				textBox.CustomBox2 (Step2C, yourAnswer + g0);
			}

			public void toRGB_B() {
				Console.WriteLine (text[0][2]);
				textBox.CustomBox2 (Step3, text[2][3]);
				Console.Write (text[4][3] + text[0][2] + ">> ");
				b = Console.ReadLine ();
				b0 = b;
				b1 = float.Parse (b0);
				b2 = b1 * 255;
				b3 = Math.Round (b2); 
				b4 = b3.ToString ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Step1C, yourAnswer + r0);
				textBox.CustomBox2 (Step2C, yourAnswer + g0);
				textBox.CustomBox2 (Step3C, yourAnswer + b0);
			}

			public void toRGB() {
				toRGB_R ();
				toRGB_G ();
				toRGB_B ();
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkMagenta;
				Console.Clear ();
				textBox.CustomBox3 (result2, before + r4 + text[4][1] + g4 + text[4][1] + b4, exit);
			}
		}
	}
}

