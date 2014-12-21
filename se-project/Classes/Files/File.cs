using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using se_project.Interfaces.Files;

namespace se_project.Classes.Files
{
    class File : IFile
    {
        /// <summary>
        /// File's id
        /// </summary>
        int id;

        /// <summary>
        /// Path to a file
        /// </summary>
        string path;

        /// <summary>
        /// File's size
        /// </summary>
        long size;

        /// <summary>
        /// For obtaining file's information
        /// </summary>
        FileInfo fileInfo;

        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public File()
        {

        }

        /// <summary>
        /// Constructor which initializes internal variables.
        /// </summary>
        public File(String path, int id)
        {
            this.id = id;
            this.path = path;
            this.fileInfo = new FileInfo(path);
            this.size = fileInfo.Length;
        }

        public int GetId()
        {
            return id;
        }

        public string GetPath()
        {
            return path;
        }

        public long GetSize()
        {
            return size;
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }
    }
}
