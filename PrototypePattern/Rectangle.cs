using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Rectangle : IShape
    {
        #region Private Features

        private int coordinateX;
        private int coordinateY;

        #endregion Private Features

        #region Constructors
        /// <summary>
        /// Principal Constructor
        /// </summary>
        public Rectangle()
        {

        }

        /// <summary>
        /// Constructor to create a rectangle with the coordinates
        /// </summary>
        public Rectangle(int coordinateX, int coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }

        /// <summary>
        /// Constructor to clone the object and create a prototye
        /// </summary>
        /// <param name="shape"></param>
        public Rectangle(Rectangle rectangle)
        {
            this.coordinateX = rectangle.coordinateX;
            this.coordinateY = rectangle.coordinateY;
        }

        #endregion Constructors

        #region Internal Methods

        /// <summary>
        /// Get the X Coordinate
        /// </summary>
        /// <returns>The X Coordinate</returns>
        internal int getCoordinateX()
        {
            return coordinateX;
        }

        /// <summary>
        /// Get the Y Coordinate
        /// </summary>
        /// <returns>The Y Coordinate</returns>
        internal int getCoordinateY()
        {
            return coordinateY;
        }

        /// <summary>
        /// Method that modify the coordinates of a rectangle
        /// </summary>
        /// <param name="coordinateX">The X Coordinate</param>
        /// <param name="coordinateY">The Y Coordinate</param>
        internal void modifyCoordinate(int coordinateX, int coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }

        #endregion Internal Methods

        #region Inheritance Methods

        IShape IShape.clone()
        {
            return new Rectangle(this);
        }

        #endregion Inheritance Methods
    }
}
