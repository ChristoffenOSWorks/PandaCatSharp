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

			public String choices;
			public static String choice1;

			public void choice() {
				textBox.CustomBox3 (Text.text[1][0], Text.text[1][1], Text.text[1][2]);
				Console.Write (Text.text[4][3] + Text.text[4][3] + Text.text[0][2] + Text.text[4][0]);
				choices = Console.ReadLine ();
				choice1 = choices;

				try {
					if (choices == "cairo") {
						toCairo.toCairo ();
					} else if (choices == "rgb") {
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

