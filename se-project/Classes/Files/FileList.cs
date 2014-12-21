using System;
using System.Collections.Generic;
using System.Collections;
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
        private IEnumerator position;

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
            for (int i = 0; i < filesList.Capacity; i++)
                if (filesList.ElementAt(i) == file)
                    return i;
            return -1;
        }

        public int GetOrder(int fileId)
        {
            foreach (IFile iFile in filesList)
            {
                if (iFile.GetId() == fileId)
                    return filesList.IndexOf(iFile);
            }
            return -1;
        }

        public bool SetOrder(int fileId, int order)
        {
            int index = GetOrder(fileId);
            if (index == -1)
                return false;
            IFile temp = filesList.ElementAt(index);
            filesList.RemoveAt(index);
            try
            {
                filesList.Insert(order, temp);
            }
            catch (ArgumentOutOfRangeException e)
            {
                filesList.Insert(index, temp);
                return false;
            }
            return true;
        }

        public bool SetOrder(IFile file, int order)
        {
            try
            {
                filesList.Insert(order, file);
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
            return true;
        }

        public IFile GetFile(int fileId)
        {
            foreach (IFile iFile in filesList)
                if (iFile.GetId() == fileId)
                    return iFile;
            return null;
        }

        public IFile GetNextFile()
        {
            if (position.Current == null)
            {
                position = filesList.GetEnumerator();
            }

            if (position.MoveNext())
            {
                return (IFile)position.Current;
            }
            else
            {
                return null;
            }
        }

        public bool ResetPosition()
        {
            try
            {
                position.Reset();
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
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

        public bool RemoveFile(int fileId)
        {
            try
            {
                filesList.RemoveAt(fileId);
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
