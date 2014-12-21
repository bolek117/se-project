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
        /// <summary>
        /// Getter for Id parameter.
        /// </summary>
        /// <returns>Unique id for an image</returns>
        int GetId();
        /// <summary>
        /// Setter for Id parameter.
        /// </summary>
        /// <param name="id">Unique id for an image</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetId(int id);

        /// <summary>
        /// Getter for Size parameter.
        /// </summary>
        /// <returns>Size dimensions of an image</returns>
        IXYPair GetSize();
        /// <summary>
        /// Setter for Size parameter.
        /// </summary>
        /// <param name="size">Size dimensions of an image</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetSize(IXYPair size);
        
        /// <summary>
        /// Getter for Image parameter.
        /// </summary>
        /// <returns>Reference to an image</returns>
        IFile GetImage();
        /// <summary>
        /// Setter for Image parameter.
        /// </summary>
        /// <param name="file">Reference to an image</param>
        /// <returns>True if attributes match, false otherwise</returns>
        bool SetImage(IFile file);
    }
}
