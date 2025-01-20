using System;

namespace Enemies
{
    /// <summary>Defines a Zombie class.</summary>
    class Zombie
    {
        /// <summary>Field to store the zombie's health.</summary>
        private int health;

        /// <summary>Default name is "(No name)".</summary>
        private string name = "(No name)";

        /// <summary>Default constructor, initializes health to 0.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Constructor that sets health to a specific value.</summary>
        /// <param name="value">The initial health value.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>Gets or sets the name of the zombie.</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>Gets the current health of the zombie.</summary>
        /// <returns>The health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}