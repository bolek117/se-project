using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using se_project.Interfaces.Common;
using se_project.Interfaces.Files;

namespace se_project.Classes.Image
{
    class ImageCanvas
    {
        private int _id;
        private IXYPair _size;
        private IFile _file;

        public int GetId()
        {
            return _id;
        }

        public bool SetId(int id)
        {
            _id = id;
            return _id == id;
        }

        public IXYPair GetSize()
        {
            return _size;
        }

        public bool SetSize(IXYPair size)
        {
            _size = size;
            return _size == size;
        }

        public IFile GetImage()
        {
            return _file;
        }

        public bool SetImage(IFile file)
        {
            _file = file;
            return _file == file;
        }
    }
}
