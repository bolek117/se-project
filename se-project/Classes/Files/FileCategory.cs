using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using se_project.Interfaces.Files;

namespace se_project.Classes.Files
{
    /// <summary>
    /// Class storing data related to the file categories.
    /// </summary>
    class FileCategory : IFileCategory
    {
        protected int id;
        protected String name;
        protected IFileList filesList;

        public int GetId()
        {
            return id;
        }

        public bool SetId(int id)
        {
            this.id = id;
            return true;
        }

        public string GetName()
        {
            return name;
        }

        public bool SetName(string name)
        {
            this.name = name;
            return true;
        }

        public IFileList GetFilesList()
        {
            return filesList;
        }
    }
}
