using System;
using System.Collections;
using System.IO;

using PandaCat;
using PandaCat.Colors;

namespace PandaCat {
	namespace Colors {
		public class Cairo : Tabby {
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

			public void toCairo_R_set() {
				r = Console.ReadLine ();
				r0 = r;
				r1 = float.Parse (r0);
				r2 = r1 / 255;
				r3 = Math.Round (r2, 2); 
				r4 = r3.ToString ();
			}

			public void toCairo_G_set() {
				g = Console.ReadLine ();
				g0 = g;
				g1 = float.Parse (g0);
				g2 = g1 / 255;
				g3 = Math.Round (g2, 2); 
				g4 = g3.ToString ();
			}

			public void toCairo_B_set() {
				b = Console.ReadLine ();
				b0 = b;
				b1 = float.Parse (b0);
				b2 = b1 / 255;
				b3 = Math.Round (b2, 2); 
				b4 = b3.ToString ();
				Console.WriteLine (Text.text[4][3]);
			}
				
			public void toCairo_R() {
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox1 ("Writing to: " + file + ".c");
				textBox.CustomBox2 (rgb1, rgb2);

				Console.Write (Text.text[0][2]);
				textBox.CustomBox2 (Text.text[5][3], Text.text[2][1]);
				Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");

				toCairo_R_set ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Text.text[5][0], yourAnswer + r0);
			}

			public void toCairo_G() {
				Console.Write (Text.text[0][2]);
				textBox.CustomBox2 (Text.text[5][4], Text.text[2][2]);
				Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
			
				toCairo_G_set ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Text.text[5][0], yourAnswer + r0);
				textBox.CustomBox2 (Text.text[5][1], yourAnswer + g0);
			}

			public void toCairo_B() {
				Console.Write (Text.text[0][2]);
				textBox.CustomBox2 (Text.text[5][5], Text.text[2][3]);
				Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");

				toCairo_B_set ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Text.text[5][0], yourAnswer + r0);
				textBox.CustomBox2 (Text.text[5][1], yourAnswer + g0);
				textBox.CustomBox2 (Text.text[5][2], yourAnswer + b0);

				Console.Write (Text.text[4][3] + Text.text[0][2] + "Press ENTER to see results! >> ");
				Console.ReadLine ();	
			}

			public void toCairo() {
				toCairo_R ();
				toCairo_G ();
				toCairo_B ();
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkMagenta;
				Console.Clear ();

				using (StreamWriter write2 = File.AppendText(file + ".c")) 
				{
					write2.WriteLine(setSourceRGBAStart + r4 + Text.text[4][1] + g4 + Text.text[4][1] + b4 + toCairoEnd + Text.text[4][3]);
				}	

				textBox.CustomBox3 (result1, setSourceRGBAStart + r4 + Text.text[4][1] + g4 + Text.text[4][1] + b4 + toCairoEnd, exit);
			}      
		}
	}
}

