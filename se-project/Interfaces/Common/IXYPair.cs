using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Common
{
    interface IXYPair
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetX();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        bool SetX(int x);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetY();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        bool SetY(int y);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool SetXY(int x, int y);

    }
}
