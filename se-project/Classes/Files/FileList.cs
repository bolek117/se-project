using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using se_project.Interfaces.Files;

namespace se_project.Classes.Files
{
    /// <summary>
    /// Class storing files list
    /// </summary>
    class FileList : IFileList
    {
        /// <summary>
        /// List storing categories list.
        /// </summary>
        protected List<IFile> filesList;

        /// <summary>
        /// Internal value storing actual position in the list.
        /// </summary>
        private List<IFile>.Enumerator position;

        /// <summary>
        /// Default constructor. Initializes internal variables.
        /// </summary>
        public FileList()
        {
            filesList = new List<IFile>();
            position = filesList.GetEnumerator();
        }

        public int GetOrder(IFile file)
        {
            throw new NotImplementedException();
        }

        public int GetOrder(int fileId)
        {
            throw new NotImplementedException();
        }

        public bool SetOrder(int fileId, int order)
        {
            throw new NotImplementedException();
        }

        public bool SetOrder(IFile file, int order)
        {
            throw new NotImplementedException();
        }

        public IFile GetFile(int fileId)
        {
            throw new NotImplementedException();
        }

        public IFile GetNextFile()
        {
            if (position.MoveNext())
            {
                return position.Current;
            }
            else
            {
                return null;
            }
        }

        public bool ResetPosition()
        {
            throw new NotImplementedException();
        }

        public bool AddFile(IFile file)
        {
            filesList.Add(file);
            return true;
        }

        public bool RemoveFile(IFile file)
        {
            return (filesList.Remove(file));
        }

        public bool RemoveFile(int file)
        {
            try
            {
                filesList.RemoveAt(file);
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
            return true;
        }

        public bool ClearFileList()
        {
            filesList.Clear();
            return true;
        }
    }
}
