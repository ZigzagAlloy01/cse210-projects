using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string> ();
        List<string> titles = new List<string> ();
        string goal;
        string userGoal;
        string description;
        string response = "yes";
        int userNumber;
        SimpleGoal simple = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        CheckListGoal checkList = new CheckListGoal();
        simple.FirstIndex();
        eternal.FirstIndex();
        checkList.FirstIndex();
        while (response == "yes") {
            userNumber = simple.DisplayMenu();
            if (userNumber == 1)
                {
                    int typeGoal = simple.WriteGoal();
                    if (typeGoal == 1) {
                        userGoal = simple.WriteTitle();
                        titles.Add(userGoal);
                        description = simple.WriteDescription();
                        simple.ListOfSimpleGoals(userGoal, description);
                    }
                    else if (typeGoal == 2) {
                        userGoal = eternal.WriteTitle();
                        titles.Add(userGoal);
                        description = eternal.WriteDescription();
                        eternal.ListOfEternalGoals(userGoal, description);
                    }
                    else if (typeGoal == 3) {
                        userGoal = checkList.WriteTitle();
                        titles.Add(userGoal);
                        description = checkList.WriteDescription();
                        checkList.ListOfCheckedGoals(userGoal, description);
                    }
                    
                    response = "yes";
                }
            else if (userNumber == 2)
                {
                    simple.ListGoalsSimple();
                    eternal.ListGoalsEternal();
                    checkList.ListGoalsChecklist();
                    response = "yes";
                }
            else if (userNumber == 3)
                {
                    string txt = simple.SaveGoalsSimple();
                    goals = simple.DeliverGoals();
                    eternal.SaveGoalsEternal(txt, goals);
                    goals = eternal.DeliverGoals();
                    checkList.SaveGoalsChecklist(txt, goals);
                    response = "yes";
                }
            else if (userNumber == 4)
                {
                    simple.LoadGoals();
                    simple.bringBackData();
                    simple.bringBackList();
                    response = "yes";
                }
            else if (userNumber == 5)
                {
                    Console.WriteLine("The goals are: ");
                    for (int i = 0; i < titles.Count; i++)
                        {
                            string show = titles[i];
                            Console.WriteLine($"{i+1}. {show}");
                        }
                        Console.WriteLine("Which goal did you accomplish? ");
                        string update = Console.ReadLine();
                        int goalToUpdate = int.Parse(update);
                        goal = titles[goalToUpdate-1];
                        Console.WriteLine(goal);
                    response = "yes";
                }
            else if (userNumber == 6)
                {
                   response = "no";
                }
            else if (userNumber < 1 || userNumber > 7)
                {
                    response = "no";
                }
            else if (userNumber == 7)
                {
                    
                    response = "yes";
                }    
        }

    }
}