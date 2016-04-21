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
            Console.WriteLine("Fast Food Menu:");
            foreach (MenuItem item in krustys.MenuItems)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();

            Casual tchotchkys = new Casual();
            Console.WriteLine("Casual Menu:");
            foreach (MenuItem item in tchotchkys.MenuItems)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();

            Console.WriteLine(tchotchkys.MenuItems.Exists(x => x.Name == "French Fries"));

            Console.ReadKey();
        }

        }



    }
    