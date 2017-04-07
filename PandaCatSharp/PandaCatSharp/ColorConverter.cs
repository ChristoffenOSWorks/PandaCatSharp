using System;
using System.Collections;
using System.IO;
using PandaCat.Colors;

namespace PandaCat {
	namespace Colors {
		public class userChoice : Tabby {
			public TextBoxes textBox = new TextBoxes();
			public StrLenFind spacer = new StrLenFind ();
			PandaCat.Colors.ToRGB toRGB = new PandaCat.Colors.ToRGB();
			PandaCat.Colors.Cairo toCairo = new PandaCat.Colors.Cairo();

			public void choice() {
				textBox.CustomBox3 (text[1][0], text[1][1], text[1][2]);
				Console.Write (text[4][3] + text[4][3] + text[0][2] + text[4][0]);
				try {
					String choice = Console.ReadLine ();
					if (choice == "cairo") {
						toCairo.toCairo ();
					} else if (choice == "rgb") {
						toRGB.toRGB();
					} else {
						textBox.CustomBox1("Invalid option");
					}
				} catch (EmptyException) {
					Console.Write("Failure already?");
				}

			}
		}
	}
}

