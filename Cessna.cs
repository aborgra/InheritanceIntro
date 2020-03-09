using System;

namespace InheritanceIntro {
  public class Cessna : Vehicle { // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public void RefuelTank () { }

    public override void Drive () {
      Console.WriteLine ($"Zoooooom! goes the {MainColor} {Name}.");
    }

    public override void Turn () {
      Console.WriteLine ($"The {Name} rolls a 180*.");
    }

    public override void Stop () {
      Console.WriteLine ($"The {Name} rolls to a stop on the runway.");
    }
  }
}