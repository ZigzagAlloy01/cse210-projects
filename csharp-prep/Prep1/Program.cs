class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
        Console.WriteLine("Who was the most interesting person I interacted with today? ");
        string interestingPerson = Console.ReadLine();
        Console.WriteLine("What was the best part of my day? ");
        string dayMoment = Console.ReadLine();
        Console.WriteLine("How did I see the hand of the Lord in my life today? ");
        string handLord = Console.ReadLine();
        Console.WriteLine("What was the strongest emotion I felt today? ");
        string strongestEmotion = Console.ReadLine();
        Console.WriteLine("If I had one thing I could do over today, what would it be? ");
        string doOver = Console.ReadLine();
    }
}