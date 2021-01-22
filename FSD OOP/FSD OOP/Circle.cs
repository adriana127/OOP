using System;
using System.Collections.Generic;

namespace FSD_OOP
{
    public class Circle : IColoredShape
    {
        protected double Radius { get; set; }
        public Color Color { get; set; }

        public List<Point2D> Position { get; set; }

        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
            var center = new Point2D(radius, radius);
            Position = new List<Point2D> { center };
        }

        public double Area()
        {
            return Math.PI * (Radius*Radius);
        }

        public void Draw()
        {
            Console.WriteLine("The color of the {0} is {1} and it's center is in ({2},{3}) with a radius of {4}", typeof(Circle), Color.ToString(), Position[0].X, Position[0].Y, Radius);
        }


        public void Scale(int scaling)
        {
            Radius *= scaling;
            Position.Clear();
            Position.Add(new Point2D(Radius, Radius));
        }


        public void Accept(IVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }
}
