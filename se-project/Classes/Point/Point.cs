using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

using se_project.Interfaces.Point;
using se_project.Interfaces.Common;

namespace se_project.Classes.Point
{
    /// <summary>
    /// Represents point on the canvas
    /// </summary>
    class Point : IPoint
    {
        private int id;
        private int order;
        private IPointType type;
        private IXYPair position;

        public Point(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public Interfaces.Common.IXYPair GetPosition()
        {
            return position;
        }

        public bool SetPosition(Interfaces.Common.IXYPair position)
        {
            this.position = position;
            return this.position == position;
        }

        public bool SetPosition(int x, int y)
        {
            position = new XYPair();
            position.SetXY(x, y);
            return true;
        }

        public IPointType GetPointType()
        {
            return type;
        }

        public bool SetPointType(IPointType type)
        {
            this.type = type;
            return this.type == type;
        }

        public int GetOrder()
        {
            return order;
        }

        public bool SetOrder(int order)
        {
            this.order = order;
            return this.order == order;
        }
    }
}
