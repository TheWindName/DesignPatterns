using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// Builder Pattern class interface
    /// </summary>
    internal interface IBuilder
    {
        /// <summary>
        /// Reset the object
        /// </summary>
        internal void reset();

        /// <summary>
        /// Put Cheese ingredient
        /// </summary>
        internal void setCheese();

        /// <summary>
        /// Put Bacon ingredient
        /// </summary>
        internal void setBacon();

        /// <summary>
        /// Put Tomato ingredient
        /// </summary>
        internal void setTomato();

        /// <summary>
        /// Put Pepperoni ingredient
        /// </summary>
        internal void setPepperoni();

        /// <summary>
        /// Put Ham ingredient
        /// </summary>
        internal void setHam();
    }
}
