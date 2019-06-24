using System;

namespace NumberGuess
{
    public class HumanPlayer
    {
         public static short AskForNumber()
         {
            Console.WriteLine("Let's play a game... please input a number between 1 and 1000, and we guarantee that we will be able to guess it within ten guesses.");
            short numberToGuess = (short)Int32.Parse(Console.ReadLine());
            return numberToGuess;
         }



    }
}