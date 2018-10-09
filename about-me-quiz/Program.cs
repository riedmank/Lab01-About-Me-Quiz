using System;

namespace about_me_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers = 0;

            Console.WriteLine("Welcome to the Kris Riedman Quiz");
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
                string answer = LocationChecker(Console.ReadLine().ToLower());
                if (answer == "Correct!")
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");

                Console.WriteLine("Question 3: What instrument did I play in high school?");
                if (InstrumentChecker(Console.ReadLine().ToLower()))
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");

                Console.WriteLine("Question 4: Do I have a cat named Max?(y/n)");
                if (CatChecker(Console.ReadLine()))
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");

                Console.WriteLine("Question 5: Was I in the Air Force?(y/n)");
                if (JobChecker(Console.ReadLine()))
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }
                else
                    Console.WriteLine("Wrong!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"Your score: {correctAnswers} out of 5!!");
            }
        }

        static int AgeChecker(int guess)
        {
            int age = 29;
            return age - guess;
        }

        static string LocationChecker(string guess)
        {
            string answer = "north dakota";
            if (guess == answer)
                return "Correct!";
            else
                return "Wrong!";
        }

        static bool InstrumentChecker(string guess)
        {
            string answer = "clarinet";
            if (guess == answer)
                return true;
            else
                return false;
        }

        static bool CatChecker(string guess)
        {
            string answer = "y";
            if (guess == answer)
                return true;
            else
                return false;
        }

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
