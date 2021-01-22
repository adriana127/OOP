using System.Collections.Generic;

namespace FSD_OOP
{
    public interface IColoredShape : IShape, IElement
    {
        Color Color { get; set; }
        List<Point2D> Position { get; set; }
    }
}
