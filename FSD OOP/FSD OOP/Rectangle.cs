using System;
using System.Collections.Generic;

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
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.Write("The rectangle has it's corners at: ");

            for (var index = 0; index < NumberOfAngles; index++)
            {
                Console.Write($" {alphabet[index]}({Position[index].X},{Position[index].Y}), ");
            }

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
        public void Accept(IVisitor visitor)
        {
            visitor.VisitRectangle(this);
        }
    }
}