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
        List<string> questions = new List<string> {"Who made me feel happy today?", "Which encouraging thoughts I had today?", "Which blessings from the Lord I have received?", "Who inspired me the most today, and why?", "What book, movie, or song had a significant impact on me?", "What is a mistake I made, and what did I learn from it?", "What was the most amazing thing I saw today?", "What made me laugh out loud?", "Which question have I been pondering about lately?", "What moment made me feel the most alive so far in this week?", "What made me feel proud of myself?"};
        while (response == "yes") {
            Console.WriteLine("Please, select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Delete");
            Console.Write("What would you like to do? "); 
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            Journal journal1 = new Journal();
            journal1._date = date;
            journal1._journal = journal;
            journal1._questions = questions;
            if (userNumber == 1)
                {
                    journal1.WriteJournal();
                    response = "yes";
                }
            else if (userNumber == 2)
                {
                    journal1.ShowJournal();
                    response = "yes";
                }
            else if (userNumber == 3)
                {
                    journal1.LoadJournal();
                    response = "yes";
                }
            else if (userNumber == 4)
                {
                    journal1.SaveJournal();
                    response = "yes";
                }
            else if (userNumber == 5)
                {
                    response = "no";
                }
            else if (userNumber == 6)
                {
                    journal1.DeleteJournal();
                    response = "yes";
                }
            else if (userNumber < 0 || userNumber > 6)
                {
                    response = "no";
                }
        }
    }
}