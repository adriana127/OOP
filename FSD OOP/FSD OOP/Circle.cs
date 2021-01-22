using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public class Circle : IColoredShape
    {
        protected double Radius { get; set; }
        public Color Color { get ; set ; }

        public const double PI = 3.14;

        public List<Point2D> Position { get ; set; }

        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
            Point2D center = new Point2D(radius, radius);
            Position = new List<Point2D>();
            Position.Add(center);
        }

        public double Area()
        {
            return PI * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("The color of the {0} is {1} and it's center is in ({2},{3}) with a radius of {4}",typeof(Circle),Color.ToString(), Position[0].X, Position[0].Y, Radius);
        }


        public void Scale(int scaling)
        {
            Radius *= scaling;
            Position.Clear();
            Position.Add(new Point2D(Radius, Radius));
        }
    }
}
