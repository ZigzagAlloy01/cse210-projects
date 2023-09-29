using System;

public class Job
{
    public string _position;
    public string _corporation;
    public int _inYear;
    public int _outYear;

    public void Display()
    {
        Console.WriteLine($"{_position} ({_corporation}) {_inYear}-{_outYear}");
    }
}