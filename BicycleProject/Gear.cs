class Gear {

    //Ingranaggio anteriore
    public int Chainring { get; init; }
    // Ingranaggio posteriore
    public int Cog { get; init; }

    public IWheel? Wheel { get; set; }

    public Gear(int chainring, int cog, IWheel? wheel = null)
    {
        Chainring = chainring;
        Cog = cog;
        Wheel = wheel;
    }

    public double Ratio() {
        return (double)Chainring / Cog;
    }

    public double GearInches() {
        if(Wheel == null) return 0;

        return Ratio() * Wheel.Diameter();
    }
}