using System;

namespace InheritanceIntro {
  public class Zero : Vehicle { // Says a Zero is a child of Vehicle class
    public double BatteryKWh { get; set; }

    public void ChargeBattery () { }

    public override void Drive () {
      Console.WriteLine ($"Whish goes the {MainColor} {Name}.");
    }

    public override void Turn () {
      Console.WriteLine ($"The {Name} signals a left turn.");
    }

    public override void Stop () {
      Console.WriteLine ($"The {Name} pulls a wheelie instead of stopping at the stop sign.");
    }
  }
}