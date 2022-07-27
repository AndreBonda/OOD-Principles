class RoadBike : Bicycle
{
    public string TapeColor { get; }
    
    private const int _DEFAULT_TIRE_SIZE = 23;

    public RoadBike(string size, string tapeColor, string chain, int tireSize) : base(size, chain, tireSize)
    {
        TapeColor = tapeColor;
    }

    public RoadBike(string size, string tapeColor, int tireSize) : this(size, tapeColor, _DEFAULT_CHAIN, tireSize)
    { }

    public RoadBike(string size, string tapeColor, string chain) : this(size, tapeColor, chain, _DEFAULT_TIRE_SIZE)
    { }

    public RoadBike(string size, string tapeColor) : this(size, tapeColor, _DEFAULT_CHAIN, _DEFAULT_TIRE_SIZE)
    { }

    public override RoadSpareParts Spares()
    {
        return new RoadSpareParts(Chain, TireSize, TapeColor);
    }
}