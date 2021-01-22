using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public interface IColoredShape : IShape
    {
        EColors Color { get; set; }
        List<Point2D> Position { get; set; }
    }
}
