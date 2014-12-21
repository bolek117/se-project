using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    public interface IFileList
    {
        /// <summary>
        /// Gets order of the file in the list by specifying its object 
        /// </summary>
        /// <param name="file">File to search</param>
        /// <returns>File's order, -1 if file was not found</returns>
        int GetOrder(IFile file);

        /// <summary>
        /// Gets order of the file in the list by specifying its id
        /// </summary>
        /// <param name="fileId">File's id</param>
        /// <returns>File's order, -1 if file was not found</returns>
        int GetOrder(int fileId);

        /// <summary>
        /// Sets order of the file in the list by specifying its id and order 
        /// </summary>
        /// <param name="fileId">File's id</param>
        /// <param name="order">Order to which put a file</param>
        /// <returns>True if operation succeed, false otherwise</returns>
        bool SetOrder(int fileId, int order);

        /// <summary>
        /// Sets order of the file in the list by specifying its object and order 
        /// </summary>
        /// <param name="file">File to set in the list</param>
        /// <param name="order">Order to which put a file</param>
        /// <returns>True if operation succeed, false otherwise</returns>
        bool SetOrder(IFile file, int order);

        /// <summary>
        /// Gets file from the list by specyfying its id
        /// </summary>
        /// <param name="fileId">File's id</param>
        /// <returns>File with specified file's id, null if file was not found</returns>
        IFile GetFile(int fileId);

        /// <summary>
        /// Gets a next file in the list
        /// </summary>
        /// <returns>Next file, null if file was not found</returns>
        IFile GetNextFile();

        /// <summary>
        /// Resets position of enumerator
        /// </summary>
        /// <returns>True if operation succeed, false otherwise</returns>
        bool ResetPosition();

        /// <summary>
        /// Adds file to the list by specyfying its object
        /// </summary>
        /// <param name="file">File to add</param>
        /// <returns>True if operation succeed, false otherwise</returns>
        bool AddFile(IFile file);

        /// <summary>
        /// Remove file from the list by specyfying its object
        /// </summary>
        /// <param name="file">File to remove</param>
        /// <returns>True if operation succeed, false otherwise</returns>
        bool RemoveFile(IFile file);

        /// <summary>
        /// Removes a file from the list by specyfying its id
        /// </summary>
        /// <param name="fileId">Id of file to remove</param>
        /// <returns>True if operation succeed, false otherwise</returns>
        bool RemoveFile(int fileId);

        /// <summary>
        /// Clears a list of files
        /// </summary>
        /// <returns>True if operation succeed, false otherwise</returns>
        bool ClearFileList();
    }
}
