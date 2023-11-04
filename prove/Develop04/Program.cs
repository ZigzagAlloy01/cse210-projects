using System;

class Program
{
    static void Main(string[] args)
    {
        List <string> menu = new List<string> {"Menu Options: ","1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "4. Quit", "Select a choice from the menu: "};
        for (int i = 0; i < menu.Count(); i++)
        {
            Console.WriteLine(menu[i]);
            Thread.Sleep(500);
        }
        string userChoice = Console.ReadLine();
        int activity = int.Parse(userChoice);
        if (activity == 1) {
            Console.WriteLine("Welcome to the Breathing Activity. This activity will help you relax by breathing in and out slowly. Clear your mind and focus on your breathing. How long, in seconds, would you like for your session? ");
            string secondsString = Console.ReadLine();
            int secondsInt = int.Parse(userChoice);
            Console.WriteLine("Get ready...");
            Console.WriteLine("Breathe in...");
            Console.WriteLine("Now breathe out...");
            Console.WriteLine("Well done!");

        }
    }
}