using System;
using System.Collections.Generic;
using UrbanPlanner_Final_v.Buildings;

namespace UrbanPlanner_Final_v

{
    class Program
    {
        static void Main(string[] args)
        {

            var buildingOne = new Building("512 8th Avenue", 4, 36, 34);
            var buildingTwo = new Building("64 18th St.", 2, 22, 16);
            var buildingThree = new Building("4506 Hatfield St.", 3, 16, 24);

            buildingOne.Construct();
            buildingTwo.Construct();
            buildingThree.Construct();

            buildingOne.Purchase("Bob B");
            buildingTwo.Purchase("Carlos D");
            buildingThree.Purchase("Michelle O");

            var buildingsList = new List<Building>
            {
                buildingOne, buildingTwo, buildingThree
            };


            Building.PrintBuildings(buildingsList);
            //var allBuildings = new Building { buildingOne, buildingTwo, buildingThree };

            //buildingInstance.PrintBuildings(buildingsList);

            //buildingOne.Print();
            //buildingTwo.Print();
            //buildingThree.Print();

        }
        
    }
}
