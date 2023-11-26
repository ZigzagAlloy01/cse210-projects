using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string> ();
        List<string> titles = new List<string> ();
        List<string> goalsSimple = new List<string> ();
        List<string> goalsEternal = new List<string> ();
        List<string> goalsChecklist = new List<string> ();
        List<int> associatedPointsSimple = new List<int> ();
        List<int> associatedPointsEternal = new List<int> ();
        List<int> associatedPointsChecklist = new List<int> ();
        List<int> associatedBonusPoints = new List<int> ();
        List<int> countOnce = new List<int> ();
        List<int> count = new List<int> ();
        List<int> limit = new List<int> ();
        List<int> currentPoints = new List<int> ();
        string goal;
        string userGoal;
        string description;
        string response = "yes";
        int userNumber;
        int point;
        int sum;
        int myCount;
        int myLimit;
        SimpleGoal simple = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        CheckListGoal checkList = new CheckListGoal();
        simple.FirstIndex();
        eternal.FirstIndex();
        checkList.FirstIndex();
        simple.FillList();
        eternal.FillList();
        checkList.FillList();
        goalsSimple.Add(" ");
        goalsEternal.Add(" ");
        goalsChecklist.Add(" ");
        currentPoints.Add(0);
        while (response == "yes") {
            sum = currentPoints.Sum();
            Console.WriteLine($"You have {sum} points.");
            userNumber = simple.DisplayMenu();
            if (userNumber == 1)
                {
                    int typeGoal = simple.WriteGoal();
                    if (typeGoal == 1) {
                        userGoal = simple.WriteTitle();
                        goalsSimple.Add(userGoal);
                        titles.Add(userGoal);
                        description = simple.WriteDescription();
                        simple.ListOfSimpleGoals(userGoal, description);
                    }
                    else if (typeGoal == 2) {
                        userGoal = eternal.WriteTitle();
                        goalsEternal.Add(userGoal);
                        titles.Add(userGoal);
                        description = eternal.WriteDescription();
                        eternal.ListOfEternalGoals(userGoal, description);
                    }
                    else if (typeGoal == 3) {
                        userGoal = checkList.WriteTitle();
                        goalsChecklist.Add(userGoal);
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
                    Console.WriteLine("List of points");
                    associatedPointsSimple = simple.GivePoints();
                   /* for (int i = 1; i < associatedPointsSimple.Count; i++) {
                        Console.WriteLine(associatedPointsSimple[i]);
                    }*/
                    associatedPointsEternal = eternal.GivePoints();
                   /* for (int i = 1; i < associatedPointsEternal.Count; i++) {
                        Console.WriteLine(associatedPointsEternal[i]);
                    }*/
                    associatedPointsChecklist = checkList.GivePoints();
                    /*for (int i = 1; i < associatedPointsChecklist.Count; i++) {
                        Console.WriteLine(associatedPointsChecklist[i]);
                    }*/
                    associatedBonusPoints = checkList.GiveBonusPoints();
                   /* for (int i = 1; i < associatedBonusPoints.Count; i++) {
                        Console.WriteLine(associatedPointsChecklist[i]);
                    }*/
                    countOnce = simple.GiveMyCountOnce();
                    count = checkList.GiveMyCount();
                    /*for (int i = 1; i < count.Count; i++) {
                        Console.WriteLine(count[i]);
                    }*/
                    limit = checkList.GiveMyLimit();
                /*  for (int i = 1; i < limit.Count; i++) {
                        Console.WriteLine(count[i]);
                    }
*/
                    Console.WriteLine(" ");
                    Console.WriteLine("The goals are: ");
                    Console.WriteLine("Simple Goals: ");
                    for (int i = 1; i < goalsSimple.Count; i++)
                        {
                            string show = goalsSimple[i];
                            Console.WriteLine($"{i}. {show}");
                        }
                    Console.WriteLine("Eternal Goals: ");
                    for (int i = 1; i < goalsEternal.Count; i++)
                        {
                            string show = goalsEternal[i];
                            Console.WriteLine($"{i}. {show}");
                        }
                    Console.WriteLine("Checklist Goals: ");
                    for (int i = 1; i < goalsChecklist.Count; i++)
                        {
                            string show = goalsChecklist[i];
                            Console.WriteLine($"{i}. {show}");
                        }
                    Console.Write("What kind of goal did you accomplish? (Write 1 for Simple Goals, 2 for Eternal Goals or 3 for Checklist Goals) ");
                    string kindGoal = Console.ReadLine();
                    int kindGoalInt = int.Parse(kindGoal);
                    if (kindGoalInt == 1) {
                        Console.WriteLine("Simple Goals: ");
                        for (int i = 1; i < goalsSimple.Count; i++)
                        {
                            string show = goalsSimple[i];
                            Console.WriteLine($"{i}. {show}");
                        }
                        Console.WriteLine("Which goal did you accomplish? ");
                        string update = Console.ReadLine();
                        int goalToUpdate = int.Parse(update);
                        goal = goalsSimple[goalToUpdate];
                        Console.WriteLine(goal);
                        countOnce[goalToUpdate] = countOnce[goalToUpdate] + 1;
                        point = associatedPointsSimple[goalToUpdate];
                        Console.WriteLine(point);
                        currentPoints.Add(point);
                    }
                    else if (kindGoalInt == 2) {
                        Console.WriteLine("Eternal Goals: ");
                        for (int i = 1; i < goalsEternal.Count; i++)
                        {
                            string show = goalsEternal[i];
                            Console.WriteLine($"{i}. {show}");
                        }
                        Console.WriteLine("Which goal did you accomplish? ");
                        string update = Console.ReadLine();
                        int goalToUpdate = int.Parse(update);
                        goal = goalsEternal[goalToUpdate];
                        Console.WriteLine(goal);
                        point = associatedPointsEternal[goalToUpdate];
                        Console.WriteLine(point);
                        currentPoints.Add(point);
                    }
                    else if (kindGoalInt == 3) {
                        Console.WriteLine("Checklist Goals: ");
                        for (int i = 1; i < goalsChecklist.Count; i++)
                        {
                            string show = goalsChecklist[i];
                            Console.WriteLine($"{i}. {show}");
                        }
                        Console.Write("Which goal did you accomplish? ");
                        string update = Console.ReadLine();
                        int goalToUpdate = int.Parse(update);
                        goal = goalsChecklist[goalToUpdate];
                        Console.WriteLine(goal);
                        point = associatedPointsChecklist[goalToUpdate];
                        Console.WriteLine(point);
                        currentPoints.Add(point);
                        count[goalToUpdate] = count[goalToUpdate] + 1;
                        myCount = count[goalToUpdate];
                        myLimit = limit[goalToUpdate];
                        if (myCount == myLimit) {
                            int addReward = associatedBonusPoints[goalToUpdate];
                            currentPoints.Add(addReward);
                        }
                    }
                    response = "yes";
                }
            else if (userNumber == 6)
                {
                   response = "no";
                }
            else if (userNumber < 1 || userNumber > 6)
                {
                    response = "no";
                } 
        }

    }
}