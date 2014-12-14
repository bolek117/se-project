using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using se_project.Interfaces.Files;

namespace se_project.Classes.Files
{
    class FileList : IFileList
    {

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
            throw new NotImplementedException();
        }

        public bool ResetPosition()
        {
            throw new NotImplementedException();
        }

        public bool AddFile(IFile file)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFile(IFile file)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFile(int file)
        {
            throw new NotImplementedException();
        }

        public bool ClearFileList()
        {
            throw new NotImplementedException();
        }
    }
}
