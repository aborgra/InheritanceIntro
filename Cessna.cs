using System;

namespace InheritanceIntro {
  public class Cessna : Vehicle { // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public void RefuelTank () { }

    public override void Drive () {
      Console.WriteLine ($"Zoooooom! goes the {MainColor} {Name}.");
    }
  }
}