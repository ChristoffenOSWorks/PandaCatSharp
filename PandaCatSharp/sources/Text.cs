using System;
using System.Collections;
using System.Collections.Generic;

namespace PandaCat {
	
	public class Text {
		public static String[][] text = new String[][] {

			/**
			 * Spaces at t.Text.text[0][]
			 **/
			new String[] {
				"        ",
				"            ",
				"    ",
				"                "
			},

			/**
			 * Copyrights at t.Text.text[1][]
			 **/
			new String[] {
				"(c) 2017 M. Gage Morgan. All Rights Reserved. Project start date: 2/24/2017",
				"Script to convert between sane-people RGB and near retard-level Cairo API.",
				"Type 'cairo' to convert to the Cairo-formatted RGB, or 'rgb' for the standard form."
			},

			/**
			 * convertRGB at t.Text.text[2][]
			 **/
			new String[] {
				"Please enter the R, G, and B values for the outline of the image to be generated.",
				"Enter the R value to be converted.",
				"Enter the G value to be converted.",
				"Enter the B value to be converted.",
				"Before Cairo, the original RGB values are: "
			},

			/**
			 * Box borders at t.Text.text[3][]
			 **/
			new String[] {
				"═",
				" ║",
				"║ ",
				"╔═",
				"═╗",
				"╚═",
				"═╝",
				"╟",
				"╢",
				"─",
				" ║ "
			},

			/**
			 * Punctuation for terminal at t.Text.text[4][]
			 **/
			new String[] {
				">> ",
				", ",
				"\"",
				"\n"
			},

			/**
			 * Steps and complete steps at Text.text[5][]
			 **/
			new String[] {
				"Step 1 - Complete!",
				"Step 2 - Complete!",
				"Step 3 - Complete!",

				"Step 1 - In Progress!",
				"Step 2 - In Progress!",
				"Step 3 - In Progress!"
			},
		};

		public List<String> inputs = new List<String> ();

	}
}

