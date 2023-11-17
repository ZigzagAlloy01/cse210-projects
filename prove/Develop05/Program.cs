using System;

class Program
{
    static void Main(string[] args)
    {
        string userGoal;
        string description;
        string response = "yes";
        int userNumber;
        SimpleGoal simple = new SimpleGoal();
        //EternalGoal eternal = new EternalGoal();
        while (response == "yes") {
            userNumber = simple.DisplayMenu();
            if (userNumber == 1)
                {
                    userGoal = simple.WriteTitle();
                    description = simple.WriteDescription();
                    SimpleGoal simple2 = new SimpleGoal(userGoal, description);
                    simple2.WriteGoal();
                    response = "yes";
                }
            else if (userNumber == 2)
                {
                    //journal1.ShowJournal();
                    response = "yes";
                }
            else if (userNumber == 3)
                {
                    //journal1.LoadJournal();
                    response = "yes";
                }
            else if (userNumber == 4)
                {
                   // journal1.SaveJournal();
                    response = "yes";
                }
            else if (userNumber == 5)
                {
                    response = "no";
                }
            else if (userNumber == 6)
                {
                   // journal1.DeleteJournal();
                    response = "yes";
                }
            else if (userNumber < 1 || userNumber > 6)
                {
                    response = "no";
                }
        }

    }
}