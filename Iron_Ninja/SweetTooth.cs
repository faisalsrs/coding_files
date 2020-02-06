using System;
namespace Iron_Ninja
{
    public class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1500)
                    return true;
                return false;
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
                if (item.IsSweet) { calorieIntake += 10; }
            }
            else
            {
                Console.WriteLine("The SweetTooth is full and cannot eat anymore.");
            }
        }
    }
}