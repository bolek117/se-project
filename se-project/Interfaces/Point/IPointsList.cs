using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Point
{
    interface IPointsList
    {
        /// <summary>
        /// Gets position of the point in the list by specifying its id.
        /// </summary>
        /// <param name="id">Id of the point</param>
        /// <returns>Point's position in the list or -1 if the point was not found</returns>
        int GetOrder(int id);

        /// <summary>
        /// Sets position of the point in the list by specifying its id and order
        /// </summary>
        /// <param name="id">Id of the point</param>
        /// <param name="order">Index at which the point will be inserted</param>
        /// <returns>True if the point was inserted, false otherwise</returns>
        bool SetOrder(int id, int order);

        /// <summary>
        /// Adds point to the list at given index.
        /// </summary>
        /// <param name="point">Point to be inserted</param>
        /// <param name="order">Index at which the point will be inserted</param>
        /// <returns>True if the point was inserted, false otherwise</returns>
        bool SetOrder(IPoint point, int order);

        /// <summary>
        /// Gets first point from the list.
        /// </summary>
        /// <returns>First point from the list</returns>
        IPoint GetFirstPoint();

        /// <summary>
        /// Gets last point from the list.
        /// </summary>
        /// <returns>Last point from the list</returns>
        IPoint GetLastPoint();

        /// <summary>
        /// Gets next point indicated by enumerator.
        /// </summary>
        /// <returns>Next point or null if it does not exist</returns>
        IPoint GetNextPoint();

        /// <summary>
        /// Gets previous point indicated by enumerator.
        /// </summary>
        /// <returns>Previous point or null if it does not exist</returns>
        IPoint GetPrevPoint();

        /// <summary>
        /// Resets position of the enumerator.
        /// </summary>
        /// <returns>True if the operation succeed</returns>
        bool ResetPosition();

        /// <summary>
        /// Clears the list of points.
        /// </summary>
        /// <returns>True if the operation succeed</returns>
        bool ClearPointsList();
    }
}
