using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class BirdCage : Cage
    {
        internal override Animal createAnimal()
        {
            return new Bird();
        }

        internal override string showAlert()
        {
            return "Alert Bird";
        }
    }
}
