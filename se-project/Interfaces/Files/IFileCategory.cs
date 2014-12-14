using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    interface IFileCategory
    {
        /// <summary>
        /// Returns unique identifier of the category
        /// </summary>
        /// <returns>Unique identifier of the category</returns>
        int GetId();

        /// <summary>
        /// Sets identifier of the category.
        /// </summary>
        /// <param name="id">Identifier of the category.</param>
        /// <returns>True if success, else false.</returns>
        bool SetId(int id);

        /// <summary>
        /// Retrurns name of the category.
        /// </summary>
        /// <returns>Name of the category.</returns>
        String GetName();

        /// <summary>
        /// Sets name of the category.
        /// </summary>
        /// <param name="name">New name for category.</param>
        /// <returns>True if success, else false.</returns>
        bool SetName(String name);

        /// <summary>
        /// Returns list of files.
        /// </summary>
        /// <returns>List of files.</returns>
        IFileList GetFilesList();
    }
}
