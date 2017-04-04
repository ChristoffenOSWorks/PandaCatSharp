using System;
using System.Collections.Generic;

public class PandaCat {
	public String Space1 = "        ";
	public String Space2 = "            ";
	public static String Space3 = "    ";
	public String Space4 = "                "; 

	public String before = "Before Cairo, the original RGB values are: "; 
	public String rgb = "Please enter the R, G, and B values for the outline of the image to be generated."; 
	public String convertR = "Enter the R value to be converted.";
	public String convertG = "Enter the G value to be converted.";
	public String convertB = "Enter the B value to be converted.";
	public String crtThree = "Type 'cairo' to convert to the Cairo-formatted RGB, or 'rgb' for the standard form.";
	public static String newline = "\n";
	public String bell = ">> ";
	public String end = ", ";
	public String quote = "\"";
	public String heading = "═";
	public String Vert = "║";
	public String TL = "╔";
	public String TR = "╗";
	public String BL = "╚";
	public String BR = "╝";
	public String LW = "╟";
	public String RW = "╢";
	public String subheading = "─";

	public String setSourceRGBAStart = "cairo_set_source_rgba(cr, ";
	public String toCairoEnd = ", 0.8);";
	public String exit = "Press ENTER key to exit";

	public String crtOne = "(c) 2017 M. Gage Morgan. All Rights Reserved. Project start date: 2/24/2017";
	public String crtTwo = "Script to convert between sane-people RGB and near retard-level Cairo API.";
	public static int length1;
	public static int length2;
	public static int length3;

	public String Step1C = "Step 1 - Complete!";
	public String Step2C = "Step 2 - Complete!";
	public String Step3C = "Step 3 - Complete!";

	public String Step1 = "Step 1 - In Progress!";
	public String Step2 = "Step 2 - In Progress!";
	public String Step3 = "Step 3 - In Progress!";

	public String rgb1 = "This is the Cairo-RGB color converter";
	public String rgb2 = "When you're done, hit enter to move to the next screen.";

	public String yourAnswer = "Your answer was: ";

	public String result1 = "You can now paste the following function to a Cairo C application";
		
	public static void Main (string[] args) {
		Console.ForegroundColor = ConsoleColor.White;
		Console.BackgroundColor = ConsoleColor.DarkCyan;
		Console.Clear ();

		ColorConverter converter = new ColorConverter();
		converter.choice ();

		//Console.WriteLine (newline + "Press ENTER key to exit");
		Console.Write (newline + Space3 + ">> ");
		Console.ReadLine ();

		Console.ForegroundColor = ConsoleColor.White;
		Console.BackgroundColor = ConsoleColor.Red;
		Console.Clear ();

		LineTo lineTo = new LineTo ();
		lineTo.Logic ();

	}
}


