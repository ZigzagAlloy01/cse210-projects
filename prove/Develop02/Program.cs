using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to journal program!");
        string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
        string response = "yes"; 
        List<string> journal = new List<string>();
        List<string> questions = new List<string> {"Who made me feel happy today?", "Which encouraging thoughts I had?", "Which blessing from the Lord did I saw in my life today?", "Who inspired me the most today, and why?", "What book, movie, or song had a significant impact on me today?", "What is a mistake you made today, and what did you learn from it?", "What was the most amazing thing I saw today?", "What made me laugh out loud today?", "What question have I been pondering about lately?", "What moment made me feel the most alive today?", "What did I do today that made you feel proud of myself?"};
        List<string> prompts = new List<string>();
        while (response == "yes") {
            Console.WriteLine("Please, select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? "); 
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            if (userNumber == 1)
                {
                    Random rnd = new Random();
                    string anyQuestion = questions[rnd.Next(10)];
                    Console.WriteLine(anyQuestion); 
                    string answer = Console.ReadLine();
                    prompts.Add(anyQuestion);
                    journal.Add(answer);
                    response = "yes";
                }
            else if (userNumber == 2)
                {
                     for (int i = 0; i < journal.Count; i++)
                        {
                            string inquiry = prompts[i];
                            string entry = journal[i];
                            Console.WriteLine($"Date: {date} - Prompt: {inquiry}");
                            Console.Write($"{entry}.");
                        }
                    response = "yes";
                }
            else if (userNumber == 3)
                {
                    string filename = "myFile.txt";
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");

                        string firstName = parts[0];
                        string lastName = parts[1];
                    }
                    response = "yes";
                }
            else if (userNumber == 4)
                {
                    Console.WriteLine("What is the file name? "); 
                    string answer = Console.ReadLine();
                    public static void SaveToFile(List)
                    response = "yes";
                }
            else if (userNumber == 5)
                {
                    response = "no";
                }
            else if (userNumber < 0 || userNumber > 5)
                {
                    response = "no";
                }
        }
    }
}