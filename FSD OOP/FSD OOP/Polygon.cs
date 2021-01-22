using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public interface IPolygon : IColoredShape
    {
        int NumberOfAngles { get; }
        void TranslateToPoints();
    }
}
