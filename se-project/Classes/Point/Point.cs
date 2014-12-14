using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

using se_project.Interfaces.Point;

namespace se_project.Classes.Point
{
    /// <summary>
    /// Represents point on the canvas
    /// </summary>
    class Point : IPoint
    {
        private int id;
        private int x;
        private int y;
        IPointType type;

        public int GetId()
        {
            return id;
        }

        public Interfaces.Common.IXYPair GetPosition()
        {
            throw new NotImplementedException();
        }

        public bool SetPosition(Interfaces.Common.IXYPair position)
        {
            throw new NotImplementedException();
        }

        public bool SetPosition(int x, int y)
        {
            if (x < 0 || y < 0)
                return false;
            else
            {
                this.x = x;
                this.y = y;
                return true;
            }
        }

        public IPointType GetPointType()
        {
            return type;
        }

        public bool SetPointType(IPointType type)
        {
            this.type = type;
            return true;
        }

        public bool SetPointType(int id)
        {
            throw new NotImplementedException();
        }

        public int GetOrder()
        {
            throw new NotImplementedException();
        }

        public bool SetOrder(int order)
        {
            throw new NotImplementedException();
        }
    }
}
