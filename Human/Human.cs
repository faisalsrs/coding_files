using System;

namespace Day2
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 5;
            Intelligence = 5;
            Dexterity = 5;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields

        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }

        // Build Attack method
        public int Attack(Human target)
        {
            int attack = Strength * 3;
            target.health -= attack;
            return target.health;
        }
    }

}
