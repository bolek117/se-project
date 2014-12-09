using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Point
{
    interface IPointsList
    {
        int GetOrder(int id);

        bool SetOrder(int id, int order);

        bool SetOrder(IPoint point, int order);

        IPoint GetFirstPoint();
        IPoint GetLastPoint();
        IPoint GetNextPoint();
        IPoint GetPrevPoint();

        bool ResetPosition();

        bool ClearPointsList();
    }
}
