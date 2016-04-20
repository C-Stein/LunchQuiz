using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Restaurant
    {
        public List<string> MenuItems;//must be instantiated inside the constructor function to work
        public bool HasBooze { get; set; }
        public int NumOf4Tops { get; set; }
        public int NumOf2Tops { get; set; }
        public Restaurant()
        {
            this.MenuItems = new List<string>();
        }
        public virtual int capacity()
        {
            return (NumOf4Tops * 4) + (NumOf2Tops * 2);
        }
    }
}
