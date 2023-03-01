namespace ConsoleExtension {
	class STDIn {
		public static string errorPrompt {get; set;} = "That's not a valid input, please try again.";

		public static string prompt(string promptMessage) {
			Console.Write($"{promptMessage}\n: ");
			// If we have an error reading the line, we assume an empty string
			string stringOut = Console.ReadLine() ?? "";

			// Loop our error message until we get a valid message
			while (stringOut == "") {
				Console.Write($"\n{errorPrompt}\n\n{promptMessage}\n: ");
				// If we have an error reading the line, we assume an empty string
				stringOut = Console.ReadLine() ?? "";
			}
			// Returning our value
			return stringOut;
		}


		public static int promptInt(string promptMessage, int? minimum=null, int? maximum=null) {
			int intOut;
			Console.Write($"{promptMessage}\n: ");
			// If we have an error reading the line, we assume an empty string
			int.TryParse(Console.ReadLine() ?? "", out intOut);

			// Loop our error message until we get a valid message
			while (!((minimum == null || intOut > minimum) && (maximum == null || intOut < maximum))) {
				Console.Write($"\n{errorPrompt}\n\n{promptMessage}\n: ");
				// If we have an error reading the line, we assume an empty string
				int.TryParse(Console.ReadLine() ?? "", out intOut);
			}
			// Returning our value
			return intOut;
		}

		public static double promptDouble(string promptMessage, double? minimum=null, double? maximum=null) {
			double doubleOut;
			Console.Write($"{promptMessage}\n: ");
			// If we have an error reading the line, we assume an empty string
			double.TryParse(Console.ReadLine() ?? "", out doubleOut);

			// Loop our error message until we get a valid message
			while (!((minimum == null || doubleOut > minimum) && (maximum == null || doubleOut < maximum))) {
				Console.Write($"\n{errorPrompt}\n\n{promptMessage}\n: ");
				// If we have an error reading the line, we assume an empty string
				double.TryParse(Console.ReadLine() ?? "", out doubleOut);
			}
			// Returning our value
			return doubleOut;
		}


		public static bool promptYesOrNo(string promptMessage) {
			Console.Write($"{promptMessage}\n: ");

			string validFirstChars = "yn";

			string? answer = Console.ReadLine() ?? " ";

			while (! validFirstChars.Contains(Char.ToLower(answer[0]))) {
				Console.Write($"\n{errorPrompt}\n\n{promptMessage}\n: ");

				answer = Console.ReadLine() ?? " ";
			}

			// At this point we have a valid answer
			return Char.ToLower(answer[0]) == 'y';
		}
	}
}
