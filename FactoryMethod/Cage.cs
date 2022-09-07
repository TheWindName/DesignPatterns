using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Cage class which contain animals in the zoo.
    /// </summary>
    internal abstract class Cage
    {
        /// <summary>
        /// Factory Method to create an Animal concrete.
        /// </summary>
        /// <returns>Animal created</returns>
        internal abstract Animal createAnimal();

        /// <summary>
        /// Show alerts about warnings or problems in the cage.
        /// </summary>
        /// <returns>Message alert</returns>
        internal abstract string showAlert();

        /// <summary>
        /// Insert Animals in the cage.
        /// </summary>
        internal void insertAnimal()
        {
            Animal animal = this.createAnimal();

            Console.WriteLine("Inserting animals ...");

            animal.move();
        }

        internal void feed(string food)
        {
            Animal animal = this.createAnimal();

            animal.eat(food);
        }
    }
}
