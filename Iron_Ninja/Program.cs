using System;

namespace Iron_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet selection = new Buffet();
            SpiceHound Faisal = new SpiceHound();
            SweetTooth Mila = new SweetTooth();

            while (Faisal.IsFull == false)
            {
                Console.WriteLine("Faisal consumed: ");
                Faisal.Consume(selection.Serve());
            }
            while (Mila.IsFull == false)
            {
                Console.WriteLine("Mila consumed:");
                Mila.Consume(selection.Serve());
            }
            if (Faisal.ConsumptionHistory.Count > Mila.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Faisal ate the most and he had {Faisal.ConsumptionHistory.Count} items.");
            }
            if (Mila.ConsumptionHistory.Count > Faisal.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Mila ate the most and she had {Mila.ConsumptionHistory.Count} items.");
            }
        }
    }
}
