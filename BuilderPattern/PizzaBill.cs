using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class PizzaBill
    {
        /// <summary>
        /// Variable that store the ingredients and prices about a bill.
        /// </summary>
        internal Dictionary<string, float> ingredientPrice;

        /// <summary>
        /// Principal Constructor.
        /// </summary>
        public PizzaBill()
        {
            ingredientPrice = new Dictionary<string, float>();
        }
    }
}
