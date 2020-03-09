using System;

namespace InheritanceIntro {
  public class Zero : Vehicle { // Says a Zero is a child of Vehicle class
    public double BatteryKWh { get; set; }

    public void ChargeBattery () { }

    public override void Drive () {
      Console.WriteLine ($"Whish goes the {MainColor} {Name}.");
    }
  }
}