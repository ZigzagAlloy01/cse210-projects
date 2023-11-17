public abstract class CheckListGoal {
    private int _targetTime;
    private int _bonusPoints;
    private int _timesCompleted;
    private bool _completed;
    public abstract void recordEvent();

}