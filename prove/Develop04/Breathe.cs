public class Breathe {
    private List <string> clock = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
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