using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner_Final_v.Buildings
{
    internal class Building
    {
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int Volume { get; }



        string _designer = "Ben Jarrett";
        DateTime _dateConstructed = DateTime.Now;
        string _address = "800 8th Street";
        string _owner;

        public Building(string address)
        {
            _address = address;
        }

        public Building(string address, int stories, double width, double depth) : this(address)
        {
            Stories = stories;
            Width = width;
            Depth = depth;

        }

    }
}
