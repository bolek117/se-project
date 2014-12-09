using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using se_project.Interfaces.Common;
using se_project.Interfaces.Files;

namespace se_project.Interfaces.Image
{
    interface IImageCanvas
    {
        int GetId();
        IXYPair GetSize();

        IFile GetImage();
        bool SetImage(IFile file);
    }
}
