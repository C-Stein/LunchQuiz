using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FineDining : Restaurant
    {
        public int BarSeating { get; set; }
        public override int capacity()
        {
            return base.capacity() + BarSeating;
        }

        public int NumberOfItems()
        {
            return MenuItems.Count;
        }
    }
}
