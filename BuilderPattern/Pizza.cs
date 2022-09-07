using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Pizza
    {
        internal List<string> ingredient;

        public Pizza()
        {
            ingredient = new List<string>();
        }
    }
}
