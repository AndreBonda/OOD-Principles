sealed class Scheduler : IScheduler
{
    private static Scheduler _scheduler;

    private Scheduler()
    {
    }

    /*
    Singleton pattern
    */
    public static Scheduler GetInstance() {
        if(_scheduler == null)
            _scheduler = new Scheduler();

        return _scheduler;
    }

    public bool IsScheduled(ISchedulable target, DateTime starting, DateTime ending)
    {
        // fake database reading
        var result = false;

        if(result)
            System.Console.WriteLine($"This {target.GetType()} is no available");
        else
            System.Console.WriteLine($"This {target.GetType()} is available in this period {starting.ToShortDateString()} - {ending.Date.ToShortDateString()}");

        return result;
    }
}