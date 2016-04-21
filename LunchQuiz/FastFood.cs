using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FastFood : Restaurant//should also implement interfaces you create called "IProvidesDinner" and "IProvidesLunch"
    {   
        public bool HasDriveThrough { get; set; }
        public FastFood()
        {
        }
        public void addMenuItem(string itemName)
        {
            MenuItem newItem = new MenuItem();
            newItem.Name = itemName;
            MenuItems.Add(newItem);
        }

        public void addMenuItem(string itemName, double itemPrice)
        {
            MenuItem thingToAdd = new MenuItem();
            thingToAdd.Name = itemName;
            thingToAdd.Price = itemPrice;
            MenuItems.Add(thingToAdd);
        }
    }
}
