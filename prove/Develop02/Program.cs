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
            if (userNumber == 1)
                {
                    Write writeNew = new Write();
                    writeNew._date = date;
                    writeNew._journal = journal;
                    writeNew._questions = questions;
                    writeNew.Display();
                    response = "yes";
                }
            else if (userNumber == 2)
                {
                    Show displayNew = new Show();
                    displayNew._journal = journal;
                    displayNew.Display();
                    response = "yes";
                }
            else if (userNumber == 3)
                {
                    Load loadNew = new Load();
                    loadNew._journal = journal;
                    loadNew.Display();
                    response = "yes";
                }
            else if (userNumber == 4)
                {
                    Save saveNew = new Save();
                    saveNew._journal = journal;
                    saveNew.Display();
                    response = "yes";
                }
            else if (userNumber == 5)
                {
                    response = "no";
                }
            else if (userNumber == 6)
                {
                    Delete deleteNew = new Delete();
                    deleteNew._journal = journal;
                    deleteNew.Display();
                    response = "yes";
                }
            else if (userNumber < 0 || userNumber > 6)
                {
                    response = "no";
                }
        }
    }
}