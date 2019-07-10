using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            var cityBuildings = new List<Building>();

            var OneElevenFirst = new Building("111 1st Street");
            OneElevenFirst.Stories = 10;
            OneElevenFirst.Width = 100.50;
            OneElevenFirst.Depth = 100.50;

            var TwoFiftySecond = new Building("250 2nd Avenue");
            TwoFiftySecond.Stories = 50;
            TwoFiftySecond.Width = 250.25;
            TwoFiftySecond.Depth = 150.30;

            var TenTwentyFiveMain = new Building("1025 Main Street");
            TenTwentyFiveMain.Stories = 5;
            TenTwentyFiveMain.Width = 50.00;
            TenTwentyFiveMain.Depth = 50.00;

            OneElevenFirst.Construct();
            TwoFiftySecond.Construct();
            TenTwentyFiveMain.Construct();

            cityBuildings.Add(OneElevenFirst);
            cityBuildings.Add(TwoFiftySecond);
            cityBuildings.Add(TenTwentyFiveMain);

            OneElevenFirst.Purchase("Joey Driscol");
            TwoFiftySecond.Purchase("Dan Storm");
            TenTwentyFiveMain.Purchase("Deep Patel");

            var Atlanta = new City("Atlanta");
            Atlanta.ElectMayor("Sean Glavin");

            foreach (Building spot in cityBuildings)
            {
                Atlanta.AddBuilding(spot);
            }

            foreach (Building structure in Atlanta.Buildings)
            {
                structure.Print();
            }
        }
    }
}
