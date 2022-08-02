var rb = new RoadBike("M", "red");
PrintSpares(rb);

var mtb = new MountainBike("S", "Shimano", "Fox");
PrintSpares(mtb);

var mtb2 = new MountainBike("S", "Shimano", "Fox", 2.9f);
PrintSpares(mtb2);

// var mtb3 = new MountainBike("S", "Shimano", "Fox", "18-speed", 2.5f);
// PrintSpares(mtb3);

// var mtb4 = new MountainBike("S", "Shimano", "Shimano", "25-speed");
// PrintSpares(mtb4);

// var rb1 = new RoadBike("M","Blue", "11-speed");
// PrintSpares(rb1);

// var rb2 = new RoadBike("M","Green", 28);
// PrintSpares(rb2);

// var roadBike = new RoadBike("M", "red");
// roadBike.IsSchedulable(DateTime.Now, DateTime.Now.AddDays(3));

static void PrintSpares(IBicycle bicycle) {
    Console.WriteLine(bicycle.Spares());
}