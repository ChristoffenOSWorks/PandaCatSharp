using System;
using System.Collections;
using System.Collections.Generic;
using PandaCat.Colors;
namespace PandaCat {
	public class History : Tabby {
		TextBoxes textBox = new TextBoxes();
		public String line;
		public void adding1() {	
			t.inputs.Add(file);
			t.inputs.AddRange (Resolution.hw);
			t.inputs.Add(Colors.userChoice.choice1);
		}

		public void adding2() {
			t.inputs.Add(file);
			t.inputs.AddRange (Resolution.hw);
			t.inputs.Add(Colors.userChoice.choice1);
			t.inputs.AddRange (ToRGB.rgb);
		}

		public void history1() {
			adding1();

			foreach (string value in t.inputs) {	
				//Console.Write (t.inputs.IndexOf(value));
				line = t.inputs.IndexOf(value) + Text.text[3][10] + value;
				textBox.CustomBox1 (line);
			}
		}
	
		public void history2() {
			adding2();
			foreach (String value in t.inputs) {	
				//Console.Write (t.inputs.IndexOf(value));
				line = t.inputs.IndexOf(value) + Text.text[3][10] + value;
				textBox.CustomBox1 (line);
			}
		}
	}
}
