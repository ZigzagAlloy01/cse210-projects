using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <string> menu = new List<string> {"Menu Options: ","1. Start breathing activity", "2. Start reflecting activity", "3. Start listing activity", "4. Quit", "Select a choice from the menu: "};
        List <string> clock = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        List <string> prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        List <string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        List <string> prompts2 = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        List <string> items = new List<string> ();
        bool repeat = true;
        while (repeat == true) {
            for (int i = 0; i < menu.Count(); i++)
            {
                Console.WriteLine(menu[i]);
                Thread.Sleep(400);
            }
            string userChoice = Console.ReadLine();
            int activity = int.Parse(userChoice);
            if (activity == 1) {
                Console.WriteLine("Welcome to the Breathing Activity. This activity will help you relax by breathing in and out slowly. Clear your mind and focus on your breathing. How long, in seconds, would you like for your session? ");
                string secondsString = Console.ReadLine();
                int secondsInt = int.Parse(secondsString);
                Console.Write("Get ready...");
                foreach (string s in clock) {
                    Console.Write(s);
                    Thread.Sleep(700);
                    Console.Write("\b \b");
                }
                Console.WriteLine(" ");
                int m = 3;
                while (m > 0) {
                    double k = Math.Ceiling(secondsInt * 0.4);
                    Console.WriteLine("Breathe in...");
                    while (k > 0) {
                        Console.Write(k);
                        Thread.Sleep(1000);
                        Console.Write("\b\b");
                        k--;
                    }
                    double l = Math.Ceiling(secondsInt * 0.6);
                    Console.WriteLine("Now breathe out...");
                    while (l > 0) {
                        Console.Write(l);
                        Thread.Sleep(1000);
                        Console.Write("\b\b");
                        l--;
                    }
                    m--;
                }
                Console.WriteLine("Well done!");
                Console.WriteLine($"You have completed another {secondsInt} seconds of Breathing Activity.");
                foreach (string s in clock) {
                    Console.Write(s);
                    Thread.Sleep(700);
                    Console.Write("\b \b");
                }
            }
            else if (activity == 2) {
                Console.WriteLine("Get ready...");
                foreach (string s in clock) {
                    Console.Write(s);
                    Thread.Sleep(700);
                    Console.Write("\b \b");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Consider the following prompt:");
                Random rnd = new Random();
                Console.WriteLine($"--- {prompts[rnd.Next(0,prompts.Count())]} ---");
                Console.WriteLine(" ");
                Console.WriteLine("When you have something in mind press enter to continue.");
                var userInput = Console.ReadKey();
                if(userInput.Key == ConsoleKey.Enter){
                    Console.WriteLine(" ");
                    Console.WriteLine("Now ponder on each of the following questions, related to this experience.");
                    int k = 5;
                    Console.WriteLine("You may begin in:");
                    while (k > 0) {
                        Console.Write(k);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                        k--;
                    }
                    Console.WriteLine(" ");
                    Random rnd2 = new Random();
                    Console.Write($"> {questions[rnd2.Next(0,questions.Count())]} ");
                    foreach (string s in clock) {
                        Console.Write(s);
                        Thread.Sleep(3000);
                        Console.Write("\b \b");
                    }
                    Console.WriteLine(" ");
                    Random rnd3 = new Random();
                    Console.Write($"> {questions[rnd3.Next(0,questions.Count())]} ");
                    foreach (string s in clock) {
                        Console.Write(s);
                        Thread.Sleep(3000);
                        Console.Write("\b \b");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Well done!");
                    Console.WriteLine($"You have completed another {clock.Count() * 2} seconds of Reflecting Activity.");
                    foreach (string s in clock) {
                        Console.Write(s);
                        Thread.Sleep(700);
                        Console.Write("\b \b");
                    }
                }  
            }
            else if (activity == 3) {
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine("How long, in seconds, would you like for your session? ");
                string secondsString = Console.ReadLine();
                int secondsInt = int.Parse(secondsString);
                Console.Write("Get ready...");
                foreach (string s in clock) {
                    Console.Write(s);
                    Thread.Sleep(700);
                    Console.Write("\b \b");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Consider the following prompt:");
                Random rnd = new Random();
                Console.WriteLine($"--- {prompts2[rnd.Next(0,prompts.Count())]} ---");
                int k = 5;
                    Console.WriteLine("You may begin in:");
                    while (k > 0) {
                        Console.Write(k);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                        k--;
                    }
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(secondsInt);
                    while (DateTime.Now < endTime) {
                        Console.Write("> ");
                        string item = Console.ReadLine();
                        items.Add(item);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine($"You listed {items.Count()} items");
                    Console.WriteLine(" ");
                    Console.WriteLine("Well done!");
                    foreach (string s in clock) {
                        Console.Write(s);
                        Thread.Sleep(700);
                        Console.Write("\b \b");
                    }
            }
            else if (activity == 4) {
                repeat = false;
            }
        }    
    }
}