public class List {
    private List <string> clock = new List<string> {"|", "/", "—", "\\", "|", "/", "—", "\\"};
    private List <string> prompts2 = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List <string> items = new List<string> ();
    public void ListActivity() {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string secondsString = Console.ReadLine();
        int secondsInt = int.Parse(secondsString);
        Console.Write("Get ready...");
        foreach (string s in clock) {
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Consider the following prompt:");
        Random rnd = new Random();
        int elements3 = prompts2.Count();
        Console.WriteLine($"--- {prompts2[rnd.Next(elements3)]} ---");
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
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
    }
}