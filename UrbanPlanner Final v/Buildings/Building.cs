using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        DateTime _dateConstructed; 
        string _address;
        string _owner = "";

        public Building(string address)
        {
            _address = address;
        }

        public Building(string address, int stories, double width, double depth) : this(address)
        {
            Stories = stories;
            Width = width;
            Depth = depth;
            Volume = (int)(width * depth * (3 * stories));

        }

        public void Construct()
        {
            
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner )
        {
            _owner = owner;
        }

        //public void Print()
        //{
        //    Console.WriteLine(_designer + "---------");
        //    Console.WriteLine(_owner);
        //    Console.WriteLine(_dateConstructed);
        //    Console.WriteLine(_owner);
        //    Console.WriteLine(_address);

        //}

        public static void PrintBuildings(List<Building> buildings)
        {
            foreach (var building in buildings)
            {
                Console.WriteLine($"{building._address} -------------------- ");
                Console.WriteLine($"Designed By {building._designer}");
                Console.WriteLine($"Construded on {building._dateConstructed}");
                Console.WriteLine($"Owned by {building._owner}");
                Console.WriteLine($"{building.Volume} cubic meters of space");
                Console.WriteLine("");

            }
        }



    }
}
