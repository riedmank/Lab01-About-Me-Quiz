﻿using System;

namespace about_me_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers = 0;
            Console.WriteLine("Welcome to the Kris Riedman Quiz");
            Console.WriteLine("Question 1: How old am I?");
            if (AgeChecker(int.Parse(Console.ReadLine())) == 0)
            {
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
                Console.WriteLine("Wrong!");
            Console.WriteLine("Question 2: Where was I born?");
            Console.WriteLine(LocationChecker(Console.ReadLine()));
            Console.WriteLine("Question 3: What instrument did I play in high school?");

            Console.WriteLine("Question 4: ?");

            Console.WriteLine("Question 5: ?");

            Console.WriteLine($"You got {correctAnswers} correct answers!!");
        }

        static int AgeChecker(int guess)
        {
            int age = 29;
            if (age > guess)
                return age - guess;
            else if (age < guess)
                return guess - age;
            else
                return 0;
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
    }
}
