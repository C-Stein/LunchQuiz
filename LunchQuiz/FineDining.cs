using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FineDining : Restaurant //should also implement an interface you create called "IProvidesDinner"
    {
        public int NumberofSeatsAtBar { get; set; }
        public override int capacity()
        {
            return base.capacity() + NumberofSeatsAtBar;
        }

        public int NumberOfMenuItemsItems()
        {
            return MenuItems.Count;
        }
    }
}
