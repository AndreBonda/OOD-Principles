Wheel w1 = new Wheel(26, 1.5d);
Gear foo = new Gear(52,11, w1);
Console.WriteLine(foo.Ratio());
Console.WriteLine(foo.GearInches());
Console.WriteLine(w1.Circumference());