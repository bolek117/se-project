using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Common
{
    interface IXYPair
    {
        /// <summary>
        /// Getter for X value.
        /// </summary>
        /// <returns>Width parameter of size or point coordinate</returns>
        int GetX();

        /// <summary>
        /// Setter for X value.
        /// </summary>
        /// <param name="x">Width parameter of size or point coordinate</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetX(int x);

        /// <summary>
        /// Getter for X value.
        /// </summary>
        /// <returns>Height parameter of size or point coordinate</returns>
        int GetY();

        /// <summary>
        /// Setter for X value.
        /// </summary>
        /// <param name="y">Height parameter of size or point coordinate</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetY(int y);
        
        /// <summary>
        /// Setter for X and Y values.
        /// </summary>
        /// <param name="x">Width parameter of size or point coordinate</param>
        /// <param name="y">Height parameter of size or point coordinate</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetXY(int x, int y);

    }
}
