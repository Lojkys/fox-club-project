using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public string Drink { get; set; } = "nothing";
        public string Food { get; set; } = "nothing";
        public List<string> ListOfTricks { get; set; }

        public Fox()
        {
            ListOfTricks = new List<string>();
        }

        public Fox(string name)
        {
            ListOfTricks = new List<string>();
            Name = name;
        }

        public void AddDrink(string drink)
        {
            Drink = drink;
        }

        public void AddFood(string food)
        {
            Food = food;
        }

        public void AddTrick(string trick)
        {
            ListOfTricks.Add(trick);
        }

    }
}
