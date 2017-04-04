using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class LineTo : PandaCat {

	private String x1;
	private float x2;
	private String x3;

	private String y1;
	private float y2;
	private String y3;

	public void Logic() {
		Console.ForegroundColor = ConsoleColor.White;
		Console.BackgroundColor = ConsoleColor.Red;
		Console.Clear ();

		TextBoxes textBox = new TextBoxes ();
		textBox.CustomBox1 (ltIntro);

		textBox.CustomBox2 (Step1, xval);
		Console.Write (newline + Space3 + ">> ");
		String x = Console.ReadLine ();
		x1 = x;
		x2 = float.Parse (x1);
		x3 = x2.ToString ();

		textBox.CustomBox2 (Step2, yval);
		Console.Write (newline + Space3 + ">> ");
		String y = Console.ReadLine ();
		y1 = y;
		y2 = float.Parse (y1);
		y3 = y2.ToString ();

		using (StreamWriter write = File.AppendText (file + ".c")) {
			write.WriteLine ("cairo_line_to(cr, " + x3 + end + y3 + ");");
		}

	}

}


