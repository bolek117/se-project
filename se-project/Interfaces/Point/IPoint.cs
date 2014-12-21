using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using se_project.Interfaces.Common;

namespace se_project.Interfaces.Point
{
    interface IPoint
    {
        /// <summary>
        /// Gets id of the point.
        /// </summary>
        /// <returns>Id of the point</returns>
        int GetId();

        /// <summary>
        /// Gets position of the point.
        /// </summary>
        /// <returns>Object containing position of the point</returns>
        IXYPair GetPosition();

        /// <summary>
        /// Sets position of the point.
        /// </summary>
        /// <param name="position">Object containing position of the point</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetPosition(IXYPair position);

        /// <summary>
        /// Sets position of the point.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <returns>True if the position was set correctly</returns>
        bool SetPosition(int x, int y);

        /// <summary>
        /// Gets type of the point.
        /// </summary>
        /// <returns>Object containing type of the point</returns>
        IPointType GetPointType();

        /// <summary>
        /// Sets type of the point.
        /// </summary>
        /// <param name="type">Object containing type of the point</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetPointType(IPointType type);
    }
}
