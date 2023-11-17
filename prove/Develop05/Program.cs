using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        string userGoal = Console.ReadLine();
        string description = Console.ReadLine();
        SimpleGoal simpleGoal = new SimpleGoal(userGoal, description);
        simpleGoal.recordEvent();

    }
}