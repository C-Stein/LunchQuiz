﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Restaurant
    {
        public List<MenuItem> MenuItems;//must be instantiated inside the constructor function to work;
        public List<Customer> CurrentCustomers;
        public bool HasBooze { get; set; }
        public int Numberof4PersonTables { get; set; }
        public int Numberof2PersonTables { get; set; }
        public Restaurant()
        {
            this.MenuItems = new List<MenuItem>();
            this.CurrentCustomers = new List<Customer>();
            MenuItem burger = new MenuItem
            {
                Name = "Burger",
                Price = 10,
                Description = "It's a burger",
                MealTime = "Lunch"
            };
            MenuItems.Add(burger);
        }
        public virtual int capacity()
        {
            return (Numberof4PersonTables * 4) + (Numberof2PersonTables * 2);
        }
        // list of customers w. ability to add to list
        public void AddCustomerToList(Customer newCustomer)
        {
            CurrentCustomers.Add(newCustomer);

        }
       
    }
}
