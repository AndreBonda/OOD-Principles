class SpareParts {
    public string Chain { get; init; }
    public float TireSize { get; init; }

    public SpareParts(string chain, float tireSize)
    {
        Chain = chain;
        TireSize = tireSize;
    }

    public override string ToString()
    {
        string result = string.Empty;
        foreach(var prop in this.GetType().GetProperties()){
            result += $"{prop.Name}: {prop.GetValue(this)}\n";
        }

        return result;
    }
}

class RoadSpareParts : SpareParts
{
    public string TapeColor { get; init; }

    public RoadSpareParts(string chain, float tireSize,  string tapeColor) : base(chain, tireSize)
    {
        TapeColor = tapeColor;
    }
}

class MountainSpareParts : SpareParts
{
    public string RearShock { get; init; }
    public string FrontShock { get; init; }

    public MountainSpareParts(string chain, float tireSize, string rearShock, string frontShock) : base(chain, tireSize)
    {
        RearShock = rearShock;
        FrontShock = frontShock;
    }
}