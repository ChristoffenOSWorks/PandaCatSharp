using System;
namespace PandaCat {
	public class Loop {
		public Text t = new Text ();

		public void ID10TChecker(string[] args) {
			try {
				String LineTo = "--LineTo";
				if (args[0] == LineTo) {
					CLIMethods.LineTo();
					Environment.Exit(0);
				} else if (args[0] == "--ToRGB") {
					CLIMethods.ToRGB();
					Environment.Exit(0);
				} else if (args[0] == "--ToCairo") {
					CLIMethods.ToCairo();
					Environment.Exit(0);
				} else if (args[0] == "--help") {
					CLIMethods.HLBling();
					Environment.Exit(0);
				} else {
					Console.Write("There was a problem");
					Environment.Exit(0);
				}

			} catch {
				Console.Write ("Nothing entered");
			} finally {
				CLIMethods.MainLoop();
			}

			CLIMethods.MainLoop();

		}
	}
}
