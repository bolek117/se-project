using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Point
{
    interface IPointsList
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int GetOrder(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        bool SetOrder(int id, int order);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        bool SetOrder(IPoint point, int order);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IPoint GetFirstPoint();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IPoint GetLastPoint();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IPoint GetNextPoint();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IPoint GetPrevPoint();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool ResetPosition();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool ClearPointsList();
    }
}
