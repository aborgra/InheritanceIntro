using System;

namespace InheritanceIntro {
  public class Tesla : Vehicle { // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery () { }

    public override void Drive () {
      Console.WriteLine ($"*Silence* goes the {MainColor} {Name}.");
    }
  }
}