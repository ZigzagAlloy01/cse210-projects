using System;

public class Resume
{
    public string _me;
    public List<Job> _previousJobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_me}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _previousJobs)
        {
            job.Display();
        }
    }
}