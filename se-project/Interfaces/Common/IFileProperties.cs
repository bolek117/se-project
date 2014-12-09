using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using se_project.Interfaces.Files;
using se_project.Interfaces.Point;

namespace se_project.Interfaces.Common
{
    interface IFileProperties
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IPointsList GetPointsList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsList"></param>
        /// <returns></returns>
        bool SetPointsList(IPointsList pointsList);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IFile GetFile();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        bool SetFile(IFile file);
    }
}
