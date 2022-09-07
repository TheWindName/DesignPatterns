using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class TigerCage : Cage
    {
        internal override Animal createAnimal()
        {
            return new Tiger();
        }

        internal override string showAlert()
        {
            return "Alert Tiger";
        }
    }
}
