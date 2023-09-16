using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

           Console.WriteLine("What was your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        
        if (gradeNumber >= 90 || gradeNumber >= 80 || gradeNumber >= 70) 
        {
            if (gradeNumber >= 90)
            {
                Console.WriteLine("You have an A");
                Console.WriteLine("Congratulations! You passed the course!");
            }
            else if (gradeNumber >= 80)
            {
                Console.WriteLine("You have a B");
                Console.WriteLine("Congratulations! You passed the course!");
            }
            else if (gradeNumber >= 70)
            {
                Console.WriteLine("You have a C");
                Console.WriteLine("Congratulations! You passed the course!");
            }
        }
        else if (gradeNumber >= 60 || gradeNumber < 60) 
        {
            
            if (gradeNumber >= 60)
            {
                Console.WriteLine("You have a D");
                Console.WriteLine("Sorry, not yet. Repeat this course.");
            }
            else if (gradeNumber < 60)
            {
                Console.WriteLine("You have an F");
                Console.WriteLine("Sorry, not yet. Repeat this course.");
            }
        }
    }
}