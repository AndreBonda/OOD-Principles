abstract class Bicycle : IBicycle, ISchedulable
{
    public string Size { get; init; }
    public string Chain { get; set; }
    public float TireSize { get; set; }

    protected const string _DEFAULT_CHAIN = "11-speed";

    public Bicycle(string size, string chain, float tireSize)
    {
        Size = size;
        Chain = chain;
        TireSize = tireSize;
    }

    public int LeadDays()
    {
        return 1;
    }

    public bool IsSchedulable(DateTime starting, DateTime ending)
    {
        return !Scheduler
            .GetInstance()
            .IsScheduled(this, starting.AddDays(this.LeadDays()), ending);
    }

    public abstract SpareParts Spares();
}