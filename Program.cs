using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pemograman.ClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = " Andi ";
            taxi.OnDuty = Yes;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.Readkey();
        }
    }
}