abstract class Bicycle {
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

    public abstract SpareParts Spares();
}