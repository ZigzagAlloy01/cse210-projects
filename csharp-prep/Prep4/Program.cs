using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string response = "yes"; 
        List<int> numbers = new List<int>(); 
        while (response == "yes") { 
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            numbers.Add(userNumber);
            if (userNumber != 0)
                {
                response = "yes";
                }
            else if (userNumber == 0)
                {
                Console.WriteLine("Lower");
                response = "no";
                }
        }
        int result = numbers.Sum();
        Console.Write("The sum is: ");
        Console.WriteLine(result);
        double average = numbers.Average();
        Console.Write("The average is: ");
        Console.WriteLine(average);
        int max = numbers.Max();
        Console.Write("The largest number is: ");
        Console.WriteLine(max);
    }
}