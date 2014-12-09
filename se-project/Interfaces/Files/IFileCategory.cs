using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    interface IFileCategory
    {
        int GetId();

        bool SetId(int id);

        String GetName();

        bool SetName(String name);

        IFileList GetFilesList();

        bool ClearFilesList();
    }
}
