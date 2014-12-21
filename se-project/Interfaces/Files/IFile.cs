using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    public interface IFile
    {
        /// <summary>
        /// Gets file's id
        /// </summary>
        /// <returns>File's id</returns>
        int GetId();

        /// <summary>
        /// Gets file's path
        /// </summary>
        /// <returns>File's path</returns>
        String GetPath();

        /// <summary>
        /// Gets file's size
        /// </summary>
        /// <returns>File's size</returns>
        long GetSize();

        /// <summary>
        /// Sets file's id
        /// </summary>
        /// <param name="id">File's id</param>
        bool SetId(int id);

        /// <summary>
        /// Sets file's path
        /// </summary>
        /// <param name="path">File's path</param>
        bool SetPath(String path);
    }
}
