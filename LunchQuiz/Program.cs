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

            Customer Bob = new Customer();
            Restaurant joes = new Restaurant();
            MenuItem coke = new MenuItem();
            coke.Name = "coke";
            MenuItem lasagna = new MenuItem();
            lasagna.Name = "lasagna";
            MenuItem milkshake = new MenuItem();
            milkshake.Name = "milkshake";

            joes.MenuItems.Add(coke);
            joes.MenuItems.Add(lasagna);
            joes.MenuItems.Add(milkshake);

            //The object initializer syntax used for bobsOrder is a shortcut used to set properties on an object when creating it
            Order bobsOrder = new Order
            {
                Drink = "coke",
                Entree = "lasagna",
                Dessert = "milkshake"
            };

            Bob.ReadyToPlaceOrder(bobsOrder, joes );

            Console.WriteLine(joes.MenuItems.Exists(x => x.Name == bobsOrder.Drink));
            Console.WriteLine(joes.MenuItems.Exists(x => x.Name == bobsOrder.Entree));
            Console.WriteLine(joes.MenuItems.Exists(x => x.Name == bobsOrder.Dessert));


            Console.ReadKey();
        }

        }



    }
    