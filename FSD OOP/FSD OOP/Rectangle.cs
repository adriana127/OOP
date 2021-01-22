using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public class Rectangle : IPolygon
    {
        public Rectangle(double height, double width, Color color)
        {
            Height = height;
            Width = width;
            Color = color;

            TranslateToPoints();
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public int NumberOfAngles => 4;

        public Color Color { get; set; }
        public List<Point2D> Position { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public void Draw()
        {
            Console.WriteLine(
                $"The Rectangle is located at: A({Position[0].X},{Position[0].Y}), B({Position[1].X},{Position[1].Y}), C({Position[2].X},{Position[2].Y}), D({Position[3].X},{Position[3].Y}).");

            Console.WriteLine($"The color of the rectangle is: {Color}");
        }

        public void Scale(int scaling)
        {
            Height += scaling;
            Width += scaling;
            TranslateToPoints();
        }

        public void TranslateToPoints()
        {
            Position = new List<Point2D>
            {
                new Point2D(0, 0), new Point2D(Height, 0), new Point2D(0, Width), new Point2D(Height, Width)
            };

        }
    }
}
