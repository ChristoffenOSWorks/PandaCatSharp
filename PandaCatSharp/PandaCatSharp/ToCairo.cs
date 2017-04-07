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

			public void toCairo_R() {
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox1 ("Writing to: " + file + ".c");
				textBox.CustomBox2 (rgb1, rgb2);

				Console.Write (Text.text[0][2]);
				textBox.CustomBox2 (Step1, Text.text[2][1]);
				Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
				String r = Console.ReadLine ();
				r0 = r;
				r1 = float.Parse (r0);
				r2 = r1 / 255;
				r3 = Math.Round (r2, 2); 
				r4 = r3.ToString ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Step1C, yourAnswer + r0);
			}

			public void toCairo_G() {
				Console.Write (Text.text[0][2]);
				textBox.CustomBox2 (Step2, Text.text[2][2]);
				Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
				String g = Console.ReadLine ();
				g0 = g;
				g1 = float.Parse (g0);
				g2 = g1 / 255;
				g3 = Math.Round (g2, 2); 
				g4 = g3.ToString ();

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Step1C, yourAnswer + r0);
				textBox.CustomBox2 (Step2C, yourAnswer + g0);
			}

			public void toCairo_B() {
				Console.Write (Text.text[0][2]);
				textBox.CustomBox2 (Step3, Text.text[2][3]);
				Console.Write (Text.text[4][3] + Text.text[0][2] + ">> ");
				String b = Console.ReadLine ();
				b0 = b;
				b1 = float.Parse (b0);
				b2 = b1 / 255;
				b3 = Math.Round (b2, 2); 
				b4 = b3.ToString ();
				Console.WriteLine (Text.text[4][3]);

				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.Clear ();
				textBox.CustomBox2 (rgb1, rgb2);
				textBox.CustomBox2 (Step1C, yourAnswer + r0);
				textBox.CustomBox2 (Step2C, yourAnswer + g0);
				textBox.CustomBox2 (Step3C, yourAnswer + b0);

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

