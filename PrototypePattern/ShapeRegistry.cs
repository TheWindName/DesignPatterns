using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// Shape Registry class
    /// </summary>
    internal class ShapeRegistry
    {
        /// <summary>
        /// The shape registry.
        /// </summary>
        private Dictionary<string, IShape> shape;

        /// <summary>
        /// Principal Constructor.
        /// </summary>
        public ShapeRegistry()
        {
            shape = new Dictionary<string, IShape>();
        }

        /// <summary>
        /// Method which provide us a way to get a concrete shape through the Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal IShape? getById(string id)
        {
            return shape.ContainsKey(id) ? shape[id] : null;
        }

        /// <summary>
        /// Add new shape to shape registries.
        /// </summary>
        /// <param name="id">ID of shape</param>
        /// <param name="shape">The shape</param>
        internal void addShape(string id, IShape shape)
        {
            this.shape.Add(id, shape);
        }
    }
}
