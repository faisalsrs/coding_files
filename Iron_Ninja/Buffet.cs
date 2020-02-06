using System;
using System.Collections.Generic;
namespace Iron_Ninja
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
         {
            new Food("Dhaal", 400, true, false),
            new Food("Naan", 200, false, false),
            new Food("Riata", 50, false, false),
            new Food("Chutney", 50, false, true),
            new Food("Lado", 100, false, true),
            new Food("Mita Chawal", 300, true, true),
            new Food("Mittai", 400, false, true),
            new Food("Dhosa", 300, true, false),
            new Food("Chicken Briyani", 500, true, false),
            new Drink("Thai Ice Tea", 300, false, true),
            new Drink("Mango Lassi", 400, true, false),
            new Drink("Masala Chai", 200, true, true),
            new Drink("Water", 1, false, false),
            new Drink("Milk", 50, false, true),
            new Drink("Milkshake", 500, false, true),
            new Drink("Coffee", 100, false, false),
            new Drink("Green Tea", 50, false, false),

        };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            int randItem = rand.Next(Menu.Count);
            Console.WriteLine(Menu[randItem].GetInfo());
            return Menu[randItem];
        }
    }
}