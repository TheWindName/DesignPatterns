using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Animal class interface
    /// </summary>
    internal interface Animal
    {
        /// <summary>
        /// Method that command to eat to an animal. 
        /// </summary>
        /// <param name="food">The type of food to eat the animal</param>
        internal void eat(string food);

        /// <summary>
        /// Method that show us the state of animal where 
        /// the animal can be in: Asleep - Furious - Sad - hungry
        /// </summary>
        internal void state();

        /// <summary>
        /// Functionality which provide us a way to move an animal.
        /// </summary>
        internal void move();
    }
}
