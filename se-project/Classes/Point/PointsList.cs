using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using se_project.Interfaces.Point;

namespace se_project.Classes.Point
{
    /// <summary>
    /// Holds list of all points and its order
    /// </summary>
    class PointsList : IPointsList
    {
        protected List<IPoint> pointsList;
        private List<IPoint>.Enumerator position;

        public PointsList()
        {
            pointsList = new List<IPoint>();
            position = pointsList.GetEnumerator();
        }

        public int GetOrder(int id)
        {
            foreach (IPoint iPoint in pointsList)
            {
                if (iPoint.GetId() == id)
                    return pointsList.IndexOf(iPoint);
            }
            return -1;
        }

        public bool SetOrder(int id, int order)
        {
            int index = GetOrder(id);
            if (index == -1)
                return false;
            IPoint temp = pointsList.ElementAt(index);
            pointsList.RemoveAt(index);
            try
            {
                pointsList.Insert(order, temp);
            }
            catch (ArgumentOutOfRangeException e)
            {
                pointsList.Insert(index, temp);
                return false;
            }
            return true;
        }

        public bool SetOrder(IPoint point, int order)
        {
            try
            {
                pointsList.Insert(order, point);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return false;
            }
            return true;
        }

        public IPoint GetFirstPoint()
        {
            return pointsList.First();
        }

        public IPoint GetLastPoint()
        {
            return pointsList.Last();
        }

        public IPoint GetNextPoint()
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

        public IPoint GetPrevPoint()
        {
            throw new NotImplementedException();
        }

        public bool ResetPosition()
        {
            throw new NotImplementedException();
        }

        public bool ClearPointsList()
        {
            pointsList.Clear();
            return true;
        }
    }
}
