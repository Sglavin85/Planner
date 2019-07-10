using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _cityName;
        private DateTime _established;

        public string Mayor { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();

        public City(string name)
        {
            _cityName = name;
            _established = DateTime.Now;
        }

        public void ElectMayor(string name)
        {
            Mayor = name;
        }

        public void AddBuilding(Building name)
        {
            Buildings.Add(name);
        }

    }
}