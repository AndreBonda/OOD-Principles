class Wheel : IWheel
{
    // Diametro del cerchio
    public double RimDiameter { get; init; }
    // Diametro del pneumatico
    public double TireDiameter { get; init; }

    public Wheel(double rimDiameter, double tireDiameter)
    {
        RimDiameter = rimDiameter;
        TireDiameter = tireDiameter;
    }

    public double Diameter() {
        return (RimDiameter + (TireDiameter * 2));
    }

    public double Circumference() {
        return Diameter() * Math.PI;
    }
}