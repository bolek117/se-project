using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using se_project.Interfaces.Point;
using se_project.Interfaces.Files;
namespace se_project.Interfaces.Common
{
    interface IFileProperties
    {
        /// <summary>
        /// Gets whole list
        /// </summary>
        /// <returns></returns>
        IPointsList GetPointsList();

        /// <summary>
        /// Sets list to given <paramref name="pointList"/>
        /// </summary>
        /// <param name="pointList"></param>
        /// <returns></returns>
        bool SetPointList(IPointsList pointList);

        /// <summary>
        /// Gets actual file
        /// </summary>
        /// <returns></returns>
        IFile GetFile();

        /// <summary>
        /// Sets actual file
        /// </summary>
        /// <returns></returns>
        bool SetFile(IFile file);
    }
}
