using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NumberGuess
{
	class Game
	{
		private bool _isGameStillOn;
		private bool isHigher;
		public void Run()
		{
			// readline: choose a number between 1 and 1000
			Console.WriteLine("Write a secret number between 1 and 1000");
			int secretNumber;
			int.TryParse(Console.ReadLine(), out secretNumber );


			GuessedNumber(secretNumber);
			
		}

		private bool GuessedNumber(int number)
		{
			int highOrLow = number/2;
			bool isHigher = true;
			Console.WriteLine($"Is the number higher than {highOrLow}? y/n");
			var answer = Console.ReadLine();

			if (answer == "n")
				isHigher = false;

			return isHigher;
		}
	}
}
