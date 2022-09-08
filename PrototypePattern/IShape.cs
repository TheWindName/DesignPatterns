using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// Shape interface
    /// </summary>
    internal interface IShape
    {
        /// <summary>
        /// Clone Method
        /// </summary>
        internal IShape clone();
    }
}
