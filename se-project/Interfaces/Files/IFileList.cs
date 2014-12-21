using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    public interface IFileList
    {
        int GetOrder(IFile file);
        int GetOrder(int fileId);

        bool SetOrder(int fileId, int order);
        bool SetOrder(IFile file, int order);

        IFile GetFile(int fileId);

        IFile GetNextFile();
        bool ResetPosition();

        bool AddFile(IFile file);

        bool RemoveFile(IFile file);
        bool RemoveFile(int file);

        bool ClearFileList();
    }
}
