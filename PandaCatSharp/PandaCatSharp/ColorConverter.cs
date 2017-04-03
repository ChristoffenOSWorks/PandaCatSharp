using System;
using System.Collections;

	public class ColorConverter : PandaCat {
		public TextBoxes textBox = new TextBoxes();
		public StrLenFind spacer = new StrLenFind ();
		public ToCairo toCairoRGB = new ToCairo();

		public void choice() {
			textBox.choiceBox ();
			Console.Write (newline + newline + Space3 + ">> ");
			String choice = Console.ReadLine ();
			if (choice == "cairo") {
				//Console.Write (newline);
				toCairo ();
			} else {
				//Console.Write (newline);
				toRGB ();
			}
		}

		public void toRGB () {
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();

			Console.WriteLine (Space3);
			textBox.convertBoxR ();
			Console.Write (newline + Space3 + ">> ");
			String r = Console.ReadLine ();
			r0 = r;
			r1 = float.Parse(r0);
			r2 = r1 * 255;
			r3 = Math.Round (r2); 
			r4 = r3.ToString ();
			r5 = r4;
			//Console.WriteLine (newline);

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();
			textBox.convertRDone (r0);

			Console.WriteLine (Space3);
			textBox.convertBoxG ();
			Console.Write (newline + Space3 + ">> ");
			String g = Console.ReadLine ();
			g0 = g;
			g1 = float.Parse(g0);
			g2 = g1 * 255;
			g3 = Math.Round (g2); 
			g4 = g3.ToString ();
			//Console.WriteLine (newline);

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();
			textBox.convertRDone (r0);
			textBox.convertGDone (g0);

			Console.WriteLine (Space3);
			textBox.convertBoxB ();
			Console.Write (newline + Space3 + ">> ");
			String b = Console.ReadLine ();
			b0 = b;
			b1 = float.Parse(b0);
			b2 = b1 * 255;
			b3 = Math.Round (b2); 
			b4 = b3.ToString ();

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();
			textBox.convertRDone (r0);
			textBox.convertGDone (g0);
			textBox.convertBDone (b0);

			Console.Write (newline + Space3 + before + r4 + end + g4 + end + b4);
		}

		public void toCairo() {
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();

			Console.Write (Space3);
			textBox.convertBoxR ();
			Console.Write (newline + Space3 + ">> ");
			String r = Console.ReadLine ();
			r0 = r;
			r1 = float.Parse (r0);
			r2 = r1 / 255;
			r3 = Math.Round (r2, 2); 
			r4 = r3.ToString ();

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();
			textBox.convertRDone (r0);

			Console.Write (Space3);
			textBox.convertBoxG ();
			Console.Write (newline + Space3 + ">> ");
			String g = Console.ReadLine ();
			g0 = g;
			g1 = float.Parse (g0);
			g2 = g1 / 255;
			g3 = Math.Round (g2, 2); 
			g4 = g3.ToString ();

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();
			textBox.convertRDone (r0);
			textBox.convertGDone (g0);

			Console.Write (Space3);
			textBox.convertBoxB ();
			Console.Write (newline + Space3 + ">> ");
			String b = Console.ReadLine ();
			b0 = b;
			b1 = float.Parse (b0);
			b2 = b1 / 255;
			b3 = Math.Round (b2, 2); 
			b4 = b3.ToString ();
			Console.WriteLine (newline);

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.choiceBox ();
			textBox.convertRDone (r0);
			textBox.convertGDone (g0);
			textBox.convertBDone (b0);

			Console.Write (newline + Space3 + "Press ENTER to see results! >> ");
			Console.ReadLine ();	

			toCairoResult ();
		}
		
		public void toCairoResult() {
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.Clear ();

			textBox.toCairoResultsBox ();

			Console.Write (newline + Space3 + Vert + setSourceRGBAStart + r4 + end + g4 + end + b4 + toCairoEnd);
			
			length1 = crtThree.Length;
			length2 = setSourceRGBAStart.Length + r4.Length + end.Length + g4.Length + end.Length + b4.Length + toCairoEnd.Length;
			while (length1 > length2) {
				Console.Write (" ");
				length2 += 1;
			}
			Console.Write(Vert);

			textBox.toCairoResultsBox2 ();
		}
		
		public void checkPath() {
			if (r1 < 256) {
				Console.Write ("Number passes validity check!\n");
			} else {
				Console.Write ("You're a failure");
			}
		}
	}      

	

