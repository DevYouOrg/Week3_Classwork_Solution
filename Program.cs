using System;

namespace DevYou_Week3_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            int age = 21;

            if (age == 21)
            {
                Console.WriteLine("You may enter");
            }

            if (age < 21)
            {
                Console.WriteLine("You may not enter");
            }

            if (age == 21)
            {
                Console.WriteLine("You are exactly the right age");
            }

            if (age != 21)
            {
                Console.WriteLine("You are either older than 21 or younger than 21");
            }

            //Exercise Two

            string secretWord = "apples";

            Console.Write("Guess secret word:  ");
            string userGuess = Console.ReadLine();

            if (userGuess == secretWord)
            {
                Console.WriteLine("You guessed correctly.");
            }
            else
            {
                Console.WriteLine("You have guessed incorrectly.");
            }

            //Exercise Three

            Console.Write("Enter Credit Score");
            int creditScore = int.Parse(Console.ReadLine());

            if (creditScore >= 400 && creditScore < 600)
            {
                Console.WriteLine("Bad Credit");
            }
            else if (creditScore >= 600 && creditScore < 700)
            {
                Console.WriteLine("Average Credit");
            }
            else if (creditScore >= 700)
            {
                Console.WriteLine("Good Credit");
            }
            else
            {
                Console.WriteLine("Unacceptable Credit");
            }

            //Code Challenge
            Console.Write("Enter a quote category: ");
            string userChoice = Console.ReadLine().ToLower();

            switch (userChoice)
            {
                case "inspirational":
                    Console.WriteLine("Be yourself; everyone else is already taken.");
                    break;
                case "morning":
                    Console.WriteLine("The early bird gets the worm");
                    break;
                case "funny":
                    Console.WriteLine("Before you judge a man, walk a mile in his shoes. After that who cares?... He's a mile away and you've got his shoes!");
                    break;
                default:
                    Console.WriteLine("We can only handle Funny, Morning and Inspirational quotes");
                    break;
            }

            //Exercise Four
            Console.Write("Enter First Number: ");
            double userFirstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double userSecondNum = int.Parse(Console.ReadLine());

            Console.Write("(1)Add (2)Subtract (3)Multiply (4)Divide");
            string calcChoice = Console.ReadLine();

            switch (calcChoice)
            {
                case "1":
                    double calcSum = userFirstNum + userSecondNum;
                    Console.WriteLine($"The sum is {calcSum}");
                    break;

                case "2":
                    double calcDifference = userFirstNum - userSecondNum;
                    Console.WriteLine($"The difference is {calcDifference}");
                    break;

                case "3":
                    double calcProduct = userFirstNum * userSecondNum;
                    Console.WriteLine($"The product is {calcProduct}");
                    break;

                case "4":
                    double calcQuotient = userFirstNum / userSecondNum;
                    Console.WriteLine($"The quotient is {calcQuotient}");
                    break;


                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }



            Console.ReadLine();
        }
    }
}
