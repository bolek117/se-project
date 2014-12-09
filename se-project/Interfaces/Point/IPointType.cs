using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Point
{
    interface IPointType
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
        String GetName();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool SetName(String name);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        String GetDescription();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        bool SetDescription(String description);
    }
}
