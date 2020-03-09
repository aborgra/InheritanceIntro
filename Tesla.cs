using System;

namespace InheritanceIntro {
  public class Tesla : Vehicle { // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery () { }

    public override void Drive () {
      Console.WriteLine ($"*Silence* goes the {MainColor} {Name}.");
    }

    public override void Turn () {
      Console.WriteLine ($"The {Name} turns right.");
    }

    public override void Stop () {
      Console.WriteLine ($"The {Name} silently stops.");
    }
  }
}