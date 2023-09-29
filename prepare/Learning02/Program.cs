using System;

class Program
{
    static void Main(string[] args)
    {
        Job jobOne = new Job();
        jobOne._position = "Full-time Missionary";
        jobOne._corporation = "The Church of Jesus Christ of Latter Day Saints";
        jobOne._inYear = 2020;
        jobOne._outYear = 2022;

        Job jobTwo = new Job();
        jobTwo._position = "Driver";
        jobTwo._corporation = "Uber";
        jobTwo._inYear = 2022;
        jobTwo._outYear = 2023;

        Resume myCV = new Resume();
        myCV._me = "Ivan Salamanca";

        myCV._previousJobs.Add(jobOne);
        myCV._previousJobs.Add(jobTwo);

        myCV.Display();
    }
}