using System;
using System.Collections;
using System.IO;

public class ColorConverter : PandaCat {
	public TextBoxes textBox = new TextBoxes();
	public StrLenFind spacer = new StrLenFind ();

	private String r0;
	private float r1;
	private float r2;
	private double r3;
	private String r4;

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

	public void choice() {
		textBox.CustomBox3 (crtOne, crtTwo, crtThree);
		Console.Write (newline + newline + Space3 + ">> ");
		try {
			String choice = Console.ReadLine ();
			if (choice == "cairo") {
				toCairo ();
			} else {
				toRGB ();
			}
		} catch (EmptyException) {
			Console.Write("Failure already?");
		}

	}

	public void toRGB () {
		try {
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.CustomBox1("Writing to: " + file + ".c");
			textBox.CustomBox2 (rgb1, rgb2);

			Console.WriteLine (Space3);
			textBox.CustomBox2 (Step1, convertR);
			Console.Write (newline + Space3 + ">> ");
			String r = Console.ReadLine ();
			r0 = r;
			r1 = float.Parse(r0);
			r2 = r1 * 255;
			r3 = Math.Round (r2); 
			r4 = r3.ToString ();

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.CustomBox2 (rgb1, rgb2);
			textBox.CustomBox2 (Step1C, yourAnswer + r0);

			Console.WriteLine (Space3);
			textBox.CustomBox2 (Step2, convertG);
			Console.Write (newline + Space3 + ">> ");
			String g = Console.ReadLine ();
			g0 = g;
			g1 = float.Parse(g0);
			g2 = g1 * 255;
			g3 = Math.Round (g2); 
			g4 = g3.ToString ();

			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear ();
			textBox.CustomBox2 (rgb1, rgb2);
			textBox.CustomBox2 (Step1C, yourAnswer + r0);
			textBox.CustomBox2 (Step2C, yourAnswer + g0);

			Console.WriteLine (Space3);
			textBox.CustomBox2 (Step3, convertB);
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
			textBox.CustomBox2 (rgb1, rgb2);
			textBox.CustomBox2 (Step1C, yourAnswer + r0);
			textBox.CustomBox2 (Step2C, yourAnswer + g0);
			textBox.CustomBox2 (Step3C, yourAnswer + b0);

			toRGBResult ();
		} catch (System.FormatException) {
			Console.WriteLine ("FAILURE");
		}
	}

	public void toCairo() {
		Console.ForegroundColor = ConsoleColor.White;
		Console.BackgroundColor = ConsoleColor.DarkCyan;
		Console.Clear ();
		textBox.CustomBox1("Writing to: " + file + ".c");
		textBox.CustomBox2 (rgb1, rgb2);

		Console.Write (Space3);
		textBox.CustomBox2 (Step1, convertR);
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
		textBox.CustomBox2 (rgb1, rgb2);
		textBox.CustomBox2 (Step1C, yourAnswer + r0);

		Console.Write (Space3);
		textBox.CustomBox2 (Step2, convertG);
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
		textBox.CustomBox2 (rgb1, rgb2);
		textBox.CustomBox2 (Step1C, yourAnswer + r0);
		textBox.CustomBox2 (Step2C, yourAnswer + g0);

		Console.Write (Space3);
		textBox.CustomBox2 (Step3, convertB);
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
		textBox.CustomBox2 (rgb1, rgb2);
		textBox.CustomBox2 (Step1C, yourAnswer + r0);
		textBox.CustomBox2 (Step2C, yourAnswer + g0);
		textBox.CustomBox2 (Step3C, yourAnswer + b0);

		Console.Write (newline + Space3 + "Press ENTER to see results! >> ");
		Console.ReadLine ();	

		toCairoResult ();
		Console.Write ("How did you fail this far in?");
	}
		
	public void toCairoResult() {
		Console.ForegroundColor = ConsoleColor.White;
		Console.BackgroundColor = ConsoleColor.DarkMagenta;
		Console.Clear ();

		using (StreamWriter write2 = File.AppendText(file + ".c")) 
		{
			write2.WriteLine(setSourceRGBAStart + r4 + end + g4 + end + b4 + toCairoEnd + newline);
		}	

		textBox.CustomBox3 (result1, setSourceRGBAStart + r4 + end + g4 + end + b4 + toCairoEnd, exit);
	}

	public void toRGBResult() {
		Console.ForegroundColor = ConsoleColor.White;
		Console.BackgroundColor = ConsoleColor.DarkMagenta;
		Console.Clear ();
		textBox.CustomBox3 (result2, before + r4 + end + g4 + end + b4, exit);
	}
		
	public void checkPath() {
		if (r1 < 256) {
			Console.Write ("Number passes validity check!\n");
		} else {
			Console.Write ("You're a failure");
		}
	}
}      

	

