using System;

namespace InheritanceIntro {
  // holds the abstractions(commonalities) from the other classes
  public class Vehicle {
    public string MainColor { get; set; }
    public int MaxOccupancy { get; set; }
    public string Name { get; set; }

    // "virtual" allows child classes to override the method
    public virtual void Drive () {
      Console.WriteLine ($"Vroom!");
    }
  }
}