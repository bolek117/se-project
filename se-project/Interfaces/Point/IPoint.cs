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
        /// 
        /// </summary>
        /// <returns></returns>
        int GetId();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IXYPair GetPosition();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        bool SetPosition(IXYPair position);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool SetPosition(int x, int y);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IPointType GetPointType();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        bool SetPointType(IPointType type);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetOrder();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool SetOrder(int order);
    }
}
