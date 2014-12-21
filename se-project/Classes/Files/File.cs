using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using se_project.Interfaces.Files;

namespace se_project.Classes.Files
{
    class File : IFile
    {
        int id;
        int size;
        string path;

        public int GetId()
        {
            return id;
        }

        public bool SetId(int id)
        {
            this.id = id;
            return true;
        }

        public string GetPath()
        {
            return path;
        }

        public bool SetPath(string path)
        {
            this.path = path;
            return true;
        }

        public int GetSize()
        {
            return size;
        }
    }
}
