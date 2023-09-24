using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() { 
            Console.WriteLine("Welcome to the Program!"); 
        } 

        static string PromptUserName() { 
            Console.Write("Please enter your name: ");
            string userInput = Console.ReadLine();
            return userInput;
        } 

        static int PromptUserNumber() { 
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        } 

        static int SquareNumber(int squareNumber) {  
            int operation = squareNumber * squareNumber;
            return operation;
        } 

        static void DisplayResult(string user, int number) { 
            Console.WriteLine($"{user}, the square of your number is {number}"); 
        } 

        DisplayWelcome();
        string userName = PromptUserName();
        int single = PromptUserNumber();
        int square = SquareNumber(single);
        DisplayResult(userName, square);
    }
}