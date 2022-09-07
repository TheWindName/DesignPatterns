using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Pizza
    {
        /// <summary>
        /// Variable that store the ingredients of a pizza.
        /// </summary>
        internal List<string> ingredient;

        /// <summary>
        /// Principal Constructor
        /// </summary>
        public Pizza()
        {
            ingredient = new List<string>();
        }

        /// <summary>
        /// Method which show all ingredients by console.
        /// </summary>
        internal void showIngredient()
        {
            foreach(var food in ingredient)
            {
                Console.WriteLine(food);
            }
        }
    }
}
