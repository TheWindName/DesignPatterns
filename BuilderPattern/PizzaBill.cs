using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class PizzaBill
    {
        internal Dictionary<string, float> ingredientPrice;

        public PizzaBill()
        {
            ingredientPrice = new Dictionary<string, float>();
        }
    }
}
