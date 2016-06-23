using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    public class Die
    {
        Random random;
        // Random is the class and random is the method
        // Random is like black box- if you push it, it will give a different number, much like a die
        public int NumberOfSides { get; set; }
        // Each radom has an operator, in this it is NumberOfSides

        /// <summary>
        /// Constructs a 6-sided Die.
        /// </summary>
        public Die() : this(6)
        // if we have public Die (); it would be a constructor (special kind of method that fills in value)
        {
            //Below is a different way you could write public Die() : this(6)
            //random = new Random();
            //NumberOfSides = 6;
        }

        /// <summary>
        /// Constructs a Die with the specified number of sides.
        /// </summary>
        /// <param name="numberOfSides">The number of sides on the Die</param>
        public Die(int numberOfSides)
        {
            // TODO
            NumberOfSides = numberOfSides;
            // Must initialize the values in the constructon
            // Assigning numberOfSides to be whatever they pass in the parenthese (NumberOfSides)
            random = new Random();
            // creates a new Random number generator object
            // meaning it is not a random number, but the generator to be able to give out random numbers
        }

        /// <summary>
        /// Rolls the die.
        /// </summary>
        /// <returns>A random number between 1 and <see cref="NumberOfSides"/></returns>
        public int Roll()
        {
            // TODO
            
            return random.Next(NumberOfSides) + 1;
            //Must use + 1 because NumberOfSides would give 0-19, not 1-20
            // Could also do below:
            //return random.Next(1, NumberOfSides +1);
        }
    }
}
