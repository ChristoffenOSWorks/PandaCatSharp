using System;
using System.Collections;
using System.Collections.Generic;
using PandaCat;
using PandaCat.Colors;

namespace PandaCat {
	namespace Colors {
		public class ToRGB {
			public TextBoxes textBox = new TextBoxes();
			public StrLenFind spacer = new StrLenFind ();

			public bool r = false;
			public bool g = false;
			public bool b = false;

			private float r0;
			public float r1;
			public float r2;
			public double r3;
			public String r4;

			private float g0;
			public float g1;
			private float g2;
			private double g3;
			private String g4;

			private float b0;
			public float b1;
			private float b2;
			private double b3;
			private String b4;
			public static String[] rgb = new String[3]; 

			public void toRGB_R_set() {
				rgb[0] = r0.ToString();
				r2 = r0 * 255;
				r3 = Math.Round (r2); 
				r4 = r3.ToString ();
			}

			public void toRGB_G_set() {
				rgb[1] = g0.ToString();
				g2 = g0 * 255;
				g3 = Math.Round (g2, 2); 
				g4 = g3.ToString ();
			}

			public void toRGB_B_set() {
				rgb[2] = b0.ToString();
				b2 = b0 * 255;
				b3 = Math.Round (b2, 2); 
				b4 = b3.ToString ();
				Console.WriteLine (Text.text[4][3]);
			}

			public void toRGB_R() {
				while (!r) {
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					Console.Clear ();
					//textBox.CustomBox1 ("Writing to: " + file + ".c");
					textBox.CustomBox2 (Text.text[7][0], Text.text[7][1]);

					Console.Write (Text.text[0][2]);
					textBox.CustomBox2 (Text.text[5][3], Text.text[2][1]);
					Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");

					r = float.TryParse(Console.ReadLine(), out r0);

					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					Console.Clear();
					textBox.CustomBox2 (Text.text[7][0], Text.text[7][1]);
					textBox.CustomBox2 (Text.text[5][0], Text.text[8][2] + r0);

					toRGB_R_set ();
				}

				toRGB_R_set ();

			}

			public void toRGB_G () {
				while (!g) {
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					Console.Clear ();

					Console.Write (Text.text[0][2]);
					textBox.CustomBox2 (Text.text[7][0], Text.text[7][1]);
					textBox.CustomBox2 (Text.text[5][0], Text.text[8][2] + r0);
					textBox.CustomBox2 (Text.text[5][4], Text.text[2][2]);
					Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");

					g = float.TryParse(Console.ReadLine(), out g0);
				}

				toRGB_G_set ();
			}

			public void toRGB_B() {

				while (!b) {
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					Console.Clear ();
					//textBox.CustomBox1 ("Writing to: " + file + ".c");
					textBox.CustomBox2 (Text.text[7][0], Text.text[7][1]);

					Console.Write (Text.text[0][2]);
					textBox.CustomBox2 (Text.text[5][0], Text.text[8][2] + r0);
					textBox.CustomBox2 (Text.text[5][1], Text.text[8][2] + g0);
					textBox.CustomBox2 (Text.text[5][5], Text.text[2][3]);
					Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");

					b = float.TryParse(Console.ReadLine(), out b0);
				}

				toRGB_B_set ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (Text.text[7][0], Text.text[7][1]);
				textBox.CustomBox2 (Text.text[5][0], Text.text[8][2] + r0);
				textBox.CustomBox2 (Text.text[5][1], Text.text[8][2] + g0);
				textBox.CustomBox2 (Text.text[5][2], Text.text[8][2] + b0);

				Console.Write (Text.text[4][3] + Text.text[0][2] + "Press ENTER to see results! >> ");
				Console.ReadLine ();	
			}

			public void toRGB() {
				toRGB_R ();
				toRGB_G ();
				toRGB_B ();
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkMagenta;
				Console.Clear ();
				textBox.CustomBox3 (Text.text[8][0], Text.text[2][4] + r4 + Text.text[4][1] + g4 + Text.text[4][1] + b4, Text.text[8][2]);
				//				Colors.userChoice uch = new userChoice ();

				Console.Write (Text.text[4][3]);
				Console.ReadLine ();

			}
		}
	}
}
