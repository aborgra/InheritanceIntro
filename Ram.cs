using System;

namespace InheritanceIntro {
  public class Ram : Vehicle { // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank () { }
    public override void Drive () {
      Console.WriteLine ($"Rumble Rumble goes the {MainColor} {Name}.");

    }

    public override void Turn () {
      Console.WriteLine ($"The {Name} turns into the work site.");
    }

    public override void Stop () {
      Console.WriteLine ($"The {Name} runs into the bulldozer.");
    }
  }
}