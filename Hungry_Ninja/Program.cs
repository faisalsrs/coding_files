using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("Dhaal", 400, true, false),
            new Food("Naan", 200, false, false),
            new Food("Riata", 50, false, false),
            new Food("Chutney", 50, false, true),
            new Food("Lado", 100, false, true),
            new Food("Mita Chawal", 300, true, true),
            new Food("Masala Chai", 100, true, true),
            new Food("Dhosa", 300, true, false),
            new Food("Chicken Briyani", 500, true, false),

        };
        }

        public Food Serve()
        {
            Random rand = new Random();
            int randFood = rand.Next(Menu.Count);
            return Menu[randFood];
        }

        class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;

            // add a constructor
            public Ninja()
            {
                calorieIntake = 0;
                FoodHistory = new List<Food>();
            }
            // add a public "getter" property called "IsFull"
            public bool IsFull
            {
                get
                {
                    if (calorieIntake > 1200)
                        return true;
                    return false;
                }
            }


            // build out the Eat method
            public void Eat(Food item)
            {
                if (IsFull == false)
                {
                    calorieIntake += item.Calories;
                    FoodHistory.Add(item);
                    Console.WriteLine($"I ate  {item.Name}.");
                    if (item.IsSpicy)
                    {
                        Console.WriteLine($"{item.Name} yumm spicy");
                    }
                    if (item.IsSweet)
                    {
                        Console.WriteLine($"{item.Name} is so sweet");
                    }
                }
                else { Console.WriteLine("This ninja ate too much! No More Food!"); }
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Buffet AYCE = new Buffet();
                Ninja Faisal = new Ninja();

                while (Faisal.IsFull != true)
                    Faisal.Eat(AYCE.Serve());
            }
        }
    }
}