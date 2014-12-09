using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using se_project;

namespace se_project.Interfaces.Common
{
    interface IToolbar
    {
        /// <summary>
        /// Executes action mapped to given <paramref name="actionId"/>
        /// </summary>
        /// <param name="actionId"></param>
        /// <returns></returns>
        bool ExecuteButtonAction(int actionId);
    }
}
