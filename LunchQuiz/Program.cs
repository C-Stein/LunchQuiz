using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            FastFood krustys = new FastFood();
            krustys.addMenuItem("Burger");
            foreach (string item in krustys.MenuItems)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
        }
    }
}
