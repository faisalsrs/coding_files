using System;
namespace Iron_Ninja
{
    public class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
                    return true;
                return false;
                {

                }
            }
        }

        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                Console.WriteLine(item);
                if (item.IsSpicy) { calorieIntake -= 5; }
            }
            else
            {
                Console.WriteLine("The SpiceHound is full and cannot eat anymore.");
            }
        }
    }
}