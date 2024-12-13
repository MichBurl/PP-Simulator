using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Creature
    {
        // Properties
        public string Name { get; set; }
        public int Level { get; set; }

        // Constructors
        public Creature(string name, int level = 1)
        {
            Name = name;
            Level = level;
        }

        public Creature()
        {
            // Default constructor, does nothing
        }

        // Read-only property Info
        public string Info => $"Name: {Name}, Level: {Level}";

        // Method SayHi
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");
        }
    }
}
