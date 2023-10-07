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
                    string entry = $"Date: {date} - Prompt: {anyQuestion} - {answer}.";
                    journal.Add(entry);
                    response = "yes";
                }
            else if (userNumber == 2)
                {
                     for (int i = 0; i < journal.Count; i++)
                        {
                            string show = journal[i];
                            Console.WriteLine(show);
                        }
                    response = "yes";
                }
            else if (userNumber == 3)
                {
                    Console.WriteLine("What is the file name? "); 
                    string answer = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(answer);
                    journal.Clear();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(" - ");
                        string dateFile = parts[0];
                        string first = parts[1];
                        string last = parts[2];
                        Console.WriteLine($"{dateFile} - {first}");
                        Console.WriteLine($" - {last}");
                        string entry = $"{dateFile} - {first} - {last}";
                        journal.Add(entry);
                    }
                    response = "yes";
                }
            else if (userNumber == 4)
                {
                    Console.WriteLine("What is the file name? "); 
                    string answer = Console.ReadLine();
                    using (StreamWriter sw = File.CreateText(answer))
                    {
                        for (int i = 0; i < journal.Count; i++)
                        {
                            string entry = journal[i];
                            sw.WriteLine(entry);
                        }
                    }
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