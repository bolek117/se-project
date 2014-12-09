using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Common
{
    interface IToolbar
    {
        /// <summary>
        /// Executes action associated with <paramref name="buttonId"/>
        /// </summary>
        /// <param name="buttonId">ID of button for which action should be performed</param>
        /// <returns>True if success, else false</returns>
        bool ExecuteButtonAction(int buttonId);
    }
}
