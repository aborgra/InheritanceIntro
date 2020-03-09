using System;

namespace InheritanceIntro {
    class Program {
        static void Main (string[] args) {
            var myBike = new Zero ();
            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;
            myBike.BatteryKWh = 10;
            myBike.Name = "Zero Bike";

            var myRoboTruck = new Tesla ();
            myRoboTruck.MainColor = "Midnight Silver";
            myRoboTruck.MaxOccupancy = 6;
            myRoboTruck.Name = "Tesla Robotruck";

            var myPlane = new Cessna ();
            myPlane.MainColor = "White";
            myPlane.MaxOccupancy = 4;
            myPlane.Name = "Cessna Plane";

            var myWorkTruck = new Ram ();
            myWorkTruck.MainColor = "Dirt Brown";
            myWorkTruck.Name = "Ram Truck";

            myWorkTruck.Drive ();
            myBike.Drive ();
            myRoboTruck.Drive ();
            myPlane.Drive ();

            myWorkTruck.Turn ();
            myBike.Turn ();
            myRoboTruck.Turn ();
            myPlane.Turn ();

            myWorkTruck.Stop ();
            myBike.Stop ();
            myRoboTruck.Stop ();
            myPlane.Stop ();
        }
    }
}