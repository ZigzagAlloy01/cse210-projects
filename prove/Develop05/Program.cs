using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string> ();
        string userGoal;
        string description;
        string response = "yes";
        int userNumber;
        SimpleGoal simple = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        CheckListGoal checkList = new CheckListGoal();
        while (response == "yes") {
            userNumber = simple.DisplayMenu();
            if (userNumber == 1)
                {
                    int typeGoal = simple.WriteGoal();
                    if (typeGoal == 1) {
                        userGoal = simple.WriteTitle();
                        description = simple.WriteDescription();
                        simple.ListOfSimpleGoals(userGoal, description);
                    }
                    else if (typeGoal == 2) {
                        userGoal = eternal.WriteTitle();
                        description = eternal.WriteDescription();
                        eternal.ListOfEternalGoals(userGoal, description);
                    }
                    else if (typeGoal == 3) {
                        userGoal = checkList.WriteTitle();
                        description = checkList.WriteDescription();
                        checkList.ListOfCheckedGoals(userGoal, description);
                    }
                    
                    response = "yes";
                }
            else if (userNumber == 2)
                {
                    simple.ListGoals();
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