﻿using System;
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
				"Program to convert human-readable instructions into Cairo-readable C programs.",
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
				"\n",
				");"
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

			/**
			 * Color RGBA functions at Text.text[6][]
			 **/
			new String[] {
				"cairo_set_source_rgba(cr, ",
				", 0.8);",
				"Press ENTER key to exit"
			},

			/**
			 * RGB text for introduction instruction box
			 * at Text.text[7][]
			 **/
			new String[] {
				"This is the Cairo-RGB color converter",
				"When you're done, hit enter to move to the next screen."
			},

			/**
			 * Result text at Text.text[8][]
			 **/
			new String[] {
				"Your values have been converted from Cairo C API to standard RGB:",
				"You can now paste the following function to a Cairo C application",
				"Your answer was: "
			},

			/**
			 * Text for entering a file and why at Text.text[9][]
			 **/
			new String[] {
				"Based on the input you provide, this app will produce vector images using a tool called Cairo.",
				"It is likely that one image is made up of stacked 'layers.'",
				"This image will be equal to 1 layer. What would you like to call it?"
			},

			/**
			 * LineTo instructions are at Text.text[10][]
			 **/
			new String[] {
				"Now for the LineTo() generator, which also generates a Cairo C function.",
				"Please enter the X value to plot.",
				"Please enter the Y value to plat."
			},

			/**
			 * C templating stuffs go here at Text.text[11][]
			 **/
			new String[] {
				"#include \"/usr/include/cairo/cairo.h\"",
				"int",
				"main (int argc, char *argv[])",
				"{",
				"cairo_surface_t *surface = ",
				"cairo_t *cr = ",
				"cairo_image_surface_create (CAIRO_FORMAT_ARGB32, ",
				"cairo_create (surface);",
				"cairo_close_path (cr);",
				"cairo_fill_preserve (cr);",
				"cairo_stroke (cr);",
				"cairo_surface_write_to_png (surface, ",
				"cairo_destroy (cr);",
				"cairo_surface_destroy (surface);",
				"return 0;",
				"}"
			},

			/**
			 * Dialog for Resolution at Text.text[12][]
			 **/
			new String [] {
				"This is the part where we determine image width and height.",
				"The image outputted by cairo has dimensions dteremined here.",
				"Enter the width of the image below.",
				"Enter the height of the image below."
			},

			/**
			 * Dialog for number of times to run the event cadence loop at Text.text[13][]
			 **/
			new String[] {
				"Please tell me how many images you would like done",
				"There will be a main event loop implemented to have this entire program run",
				"x amount of times for layered images."
			}
		};

		public static List<String> inputs = new List<String> ();

	}
}