using System;
using System.Collections;
using System.Collections.Generic;
using PandaCat.Colors;
namespace PandaCat {
	public class History {
		TextBoxes textBox = new TextBoxes();
		public String line;
		public void adding1() {	
			Text.inputs.Add(Files.file);
			Text.inputs.AddRange (Resolution.hw);
			Text.inputs.Add(PandaCat.Colors.userChoice.choice1);
		}

		public void adding2() {
			Text.inputs.Add(Files.file);
			Text.inputs.AddRange (Resolution.hw);
			Text.inputs.Add(Colors.userChoice.choice1);
			Text.inputs.AddRange (ToRGB.rgb);
		}

		public void adding3() {
			Text.inputs.Add(Files.file);
			Text.inputs.AddRange (Resolution.hw);
			Text.inputs.Add(Colors.userChoice.choice1);
			Text.inputs.AddRange (Cairo.rgb);
		}

		public void history1() {
			adding1();
			for (int i = 0; i < Text.inputs.Count; i++) {
				String value = Text.inputs[i];
				line = i + Text.text[3][10] + value;
				textBox.CustomBox1 (line);
			}
		}

		public void history2() {
			adding2();
			for (int i = 0; i < Text.inputs.Count; i++) {
				String value = Text.inputs[i];
				line = i + Text.text[3][10] + value;
				textBox.CustomBox1 (line);
			}
		}

		public void history3() {
			adding3();
			for (int i = 0; i < Text.inputs.Count; i++) {
				String value = Text.inputs[i];
				line = i + Text.text[3][10] + value;
				textBox.CustomBox1 (line);
			}
		}
	}
}
