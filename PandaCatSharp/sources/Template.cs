using System;
using System.IO;

namespace PandaCat {
	public class Template : Tabby {
		public static void LogLine(string logMessage, TextWriter w) {
			w.WriteLine(logMessage);
		}

		public static void Log(string logMessage, TextWriter w) {
			w.Write(logMessage);
		}

		String[] CText = {
			Text.text[11][0] + Text.text[4][3],
			Text.text[11][1],
			Text.text[11][2],
			Text.text[11][3],
			Text.text[0][0] + Text.text[11][4],
			Text.text[0][0] + Text.text[11][5]
		};

		public void Part1() {
			using (StreamWriter w = File.AppendText(filename + ".c")) {
				LogLine(CText[0], w);
				LogLine(Text.text[11][1], w);
				LogLine(CText[2], w);
				LogLine(CText[3], w);
				LogLine(CText[4], w);
			}
		}
	}
}
