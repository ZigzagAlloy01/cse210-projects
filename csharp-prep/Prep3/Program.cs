using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string response = "yes"; 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        while (response == "yes") { 
            Console.Write("There's a magic number here, but I won't tell you what that number is. "); 
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            if (userNumber < number)
                {
                Console.WriteLine("Higher");
                response = "yes";
                }
            else if (userNumber > number)
                {
                Console.WriteLine("Lower");
                response = "yes";
                }
            else if (userNumber == number)
                {
                Console.WriteLine("You guessed it!");
                response = "no";
                }
            
        }
    }
}