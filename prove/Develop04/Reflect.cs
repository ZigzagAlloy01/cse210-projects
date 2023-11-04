public class Reflect {
    private List <string> clock = new List<string> {"|", "/", "—", "\\", "|", "/", "—", "\\"};
    private List <string> prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List <string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public void ReflectActivity() {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string secondsString = Console.ReadLine();
        int secondsInt = int.Parse(secondsString);
        Console.WriteLine("Get ready...");
        foreach (string s in clock) {
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Consider the following prompt:");
        Random rnd = new Random();
        int elements1 = prompts.Count();
        Console.WriteLine($"--- {prompts[rnd.Next(elements1)]} ---");
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
            int elements2 = questions.Count();
            Console.Write($"> {questions[rnd2.Next(elements2)]} ");
            foreach (string s in clock) {
                Console.Write(s);
                Thread.Sleep(secondsInt*50);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
            Random rnd3 = new Random();
            Console.Write($"> {questions[rnd3.Next(elements2)]} ");
            foreach (string s in clock) {
                Console.Write(s);
                Thread.Sleep(secondsInt*50);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed another {secondsInt} seconds of Reflecting Activity.");
            foreach (string s in clock) {
                Console.Write(s);
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
        }  
    }
}