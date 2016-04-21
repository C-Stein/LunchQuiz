using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Casual : Restaurant //should also implement interfaces you create called "IProvidesDinner" and "IProvidesLunch"
    {
        public bool HasPatio { get; set; }
        public Casual()
        {
            MenuItem fries = new MenuItem
            {
                Name = "French Fries"
            };
            MenuItems.Add(fries);
        }
    }
}