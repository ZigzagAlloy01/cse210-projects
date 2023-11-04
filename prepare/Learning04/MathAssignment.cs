public class MathAssignment : Assignment
{
    private string _sectionBook;
    private string _excercise;
    public MathAssignment(string student, string topic, string sectionBook, string excercise)
        : base(student, topic)
    {
        _sectionBook = sectionBook;
        _excercise = excercise;
    }

    public string GetHomeworkList()
    {
        return $"Section {_sectionBook} excercise {_excercise}";
    }
}