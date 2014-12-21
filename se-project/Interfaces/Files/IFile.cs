using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    public interface IFile
    {
        int GetId();
        bool SetId(int id);

        String GetPath();
        bool SetPath(String path);

        int GetSize();
    }
}
