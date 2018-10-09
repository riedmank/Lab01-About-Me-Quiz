using System;

namespace about_me_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keeps track of correct answers
            int correctAnswers = 0;

            Console.WriteLine("Welcome to the Kris Riedman Quiz");

            // All user input is located inside this try block
            try
            {
                Console.WriteLine("Question 1: How old am I?");
                if (AgeChecker(int.Parse(Console.ReadLine())) == 0)
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");

                Console.WriteLine("Question 2: Where was I born?");
                // Changes user answer to lower case; makes it easier to check for a correct answer
                string answer = LocationChecker(Console.ReadLine().ToLower());
                if (answer == "Correct!")
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");

                Console.WriteLine("Question 3: What instrument did I play in high school?");
                // Changes user answer to lower case; makes it easier to check for a correct answer
                // Also, method returns a boolean
                if (InstrumentChecker(Console.ReadLine().ToLower()))
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");

                Console.WriteLine("Question 4: Do I have a cat named Max?(y/n)");
                // Method returns a boolean
                if (CatChecker(Console.ReadLine()))
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");

                Console.WriteLine("Question 5: Was I in the Air Force?(y/n)");
                // Method returns a boolean
                if (JobChecker(Console.ReadLine()))
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");
            }
            // Generic catch to catch any possible errors
            catch (Exception e)
            {
                // Print message to console
                Console.WriteLine(e.Message);
            }
            // Regardless of how far a user got on the quiz, print the number of correct answers
            finally
            {
                Console.WriteLine($"Your score: {correctAnswers} out of 5!!");
            }
        }

        // Method to check age question
        static int AgeChecker(int guess)
        {
            int age = 29;
            return age - guess;
        }

        // Method to check where I was born question
        static string LocationChecker(string guess)
        {
            string answer = "north dakota";
            if (guess == answer)
                return "Correct!";
            else
                return "Wrong!";
        }

        // Method to check what instrument I played question
        static bool InstrumentChecker(string guess)
        {
            string answer = "clarinet";
            if (guess == answer)
                return true;
            else
                return false;
        }

        // Method to check if I have a cat question
        static bool CatChecker(string guess)
        {
            string answer = "y";
            if (guess == answer)
                return true;
            else
                return false;
        }

        // Method to check if I was in the Air Force question
        static bool JobChecker(string guess)
        {
            string answer = "y";
            if (guess == answer)
                return true;
            else
                return false;
        }
    }
}
