// var rb = new RoadBike("M", "red");
// var mtb = new MountainBike("S", "Shimano", "Fox");
// var mtb2 = new MountainBike("S", "Shimano", "Fox", 2.9f);
// var mtb3 = new MountainBike("S", "Shimano", "Fox", "18-speed", 2.5f);
// var mtb4 = new MountainBike("S", "Shimano", "Shimano", "25-speed");
// var rb1 = new RoadBike("M","Blue", "11-speed");
// var rb2 = new RoadBike("M","Green", 28);

// PrintSpares(rb);
// PrintSpares(rb1);
// PrintSpares(rb2);
// PrintSpares(mtb);
// PrintSpares(mtb2);
// PrintSpares(mtb3);
// PrintSpares(mtb4);

var rb = new RoadBike("M", "red");
rb.IsSchedulable(DateTime.Now, DateTime.Now.AddDays(3));

static void PrintSpares(IBicycle bicycle) {
    Console.WriteLine(bicycle.Spares());
}