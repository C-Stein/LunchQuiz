using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Customer
    {
        public string Name { get; set; }


        //method to place order, they can only  order items that are on the current menu
        public bool ReadyToPlaceOrder(Order order, Restaurant restaurant)
        {
            if (order.VerifyOrderComplete())
            {
                if (restaurant.MenuItems.Exists(x => x.Name == order.Drink) &&
                    restaurant.MenuItems.Exists(x => x.Name == order.Entree) &&
                    restaurant.MenuItems.Exists(x => x.Name == order.Dessert))
                {
                    return true;
                }
                else
                {
                    Console.Write("line 27");
                    return false;
                }

            }
            else
            {
                Console.Write("line 34");
                return false;
            }
        }
    }
}
