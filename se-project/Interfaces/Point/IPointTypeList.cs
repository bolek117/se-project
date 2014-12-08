using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Point
{
    interface IPointTypeList
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<IPointType> GetTypesList();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool ClearTypeList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IPointType GetTypeById(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IPointType GetNextType();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newType"></param>
        /// <returns></returns>
        bool AddType(IPointType newType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeToRemove"></param>
        /// <returns></returns>
        bool RemoveType(IPointType typeToRemove);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool RemoveType(int id);
    }
}
