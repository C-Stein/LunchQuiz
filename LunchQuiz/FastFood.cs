using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FastFood : Restaurant
    {   
        public bool HasDriveThrough { get; set; }
        public void addMenuItem(string itemName)
        {

            MenuItems.Add(itemName);
        }

        public void addMenuItem(string itemName, double itemPrice)
        {
            MenuItem thingToAdd = new MenuItem();
            thingToAdd.Name = itemName;
            thingToAdd.Price = itemPrice;
            MenuItems.Add(itemName);
        }
    }
}
