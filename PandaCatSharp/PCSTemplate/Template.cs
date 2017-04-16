using System;
using System.IO;

namespace PandaCat {
	public class Template {
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
			Text.text[0][0] + Text.text[11][5],
			Text.text[0][1] + Text.text[11][6],
			Text.text[0][1] + Text.text[11][7]
		};

		public void Part1() {
			using (StreamWriter w = File.AppendText(Files.filename + ".c")) {
				LogLine(CText[0], w);
				LogLine(CText[1], w);
				LogLine(CText[2], w);
				LogLine(CText[3], w);
				LogLine(CText[4], w);
			}
		}

		public void Part2() {
			using (StreamWriter w = File.AppendText(Files.filename + ".c")) {
				LogLine(CText[5], w);
				LogLine(CText[7], w);
			}
		}
	}
}
