class MountainBike : Bicycle
{
    public string RearShock { get; }
    public string FrontShock { get; }

    private const float _DEFAULT_TIRE_SIZE = 2.1f;

    public MountainBike(string size, string rearShock, string frontShock, string chain, float tireSize) : base(size, chain, tireSize)
    {
        RearShock = rearShock;
        FrontShock = frontShock;
        SpareParts = new MountainSpareParts(Chain, TireSize, RearShock, FrontShock);
    }

    public MountainBike(string size, string rearShock, string frontShock, string chain) : this(size, rearShock, frontShock, chain, _DEFAULT_TIRE_SIZE)
    {
    }

    public MountainBike(string size, string rearShock, string frontShock, float tireSize) : this(size, rearShock, frontShock, _DEFAULT_CHAIN, tireSize)
    {
    }

    public MountainBike(string size, string rearShock, string frontShock) : this(size, rearShock, frontShock, _DEFAULT_CHAIN, _DEFAULT_TIRE_SIZE)
    {
    }
}