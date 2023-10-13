using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to journal program!");
        string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
        string response = "yes";
        int userNumber = 0; 
        List<string> journal = new List<string>();
        List<string> questions = new List<string> {"Who made me feel happy today?", "Which encouraging thoughts I had today?", "Which blessings from the Lord I have received?", "Who inspired me the most today, and why?", "What book, movie, or song had a significant impact on me?", "What is a mistake I made, and what did I learn from it?", "What was the most amazing thing I saw today?", "What made me laugh out loud?", "Which question have I been pondering about lately?", "What moment made me feel the most alive so far in this week?", "What made me feel proud of myself?"};
        Entry entry1 = new Entry();
            entry1._date = date;
            entry1._journal = journal;
            entry1._questions = questions;
        Entry entry2 = new Entry();
            entry2._userNumber = userNumber;
        Journal journal1 = new Journal();
            journal1._journal = journal;
        while (response == "yes") {
            userNumber = entry2.DisplayMenu();
            if (userNumber == 1)
                {
                    entry1.WriteJournal();
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
            else if (userNumber < 1 || userNumber > 6)
                {
                    response = "no";
                }
        }
    }
}