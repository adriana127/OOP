using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public class Triangle : IPolygon
    {
        public Triangle(Point2D x1, Point2D x2, Point2D x3, Color color)
        {
            Position = new List<Point2D>();
            Position.Add(x1);
            Position.Add(x2);
            Position.Add(x3);
            Color = color;
        }

        public int NumberOfAngles => 3;

        public Color Color { get; set; }
        public List<Point2D> Position { get; set; }

        double DistanceBetweenPoints(Point2D x1, Point2D x2)
        {
            return Math.Sqrt(Math.Pow((x1.X - x2.X), 2) + Math.Pow((x1.Y - x2.Y), 2));
        }
        double Surface()
        {
            return (DistanceBetweenPoints(Position[0], Position[1]) + DistanceBetweenPoints(Position[1], Position[2]) + DistanceBetweenPoints(Position[0], Position[2])) / 2;
        }
        public double Area()
        {
            return Math.Sqrt(Surface() * (Surface() - DistanceBetweenPoints(Position[0], Position[1])) * (Surface() - DistanceBetweenPoints(Position[0], Position[2])) * (Surface() - DistanceBetweenPoints(Position[1], Position[2])));
        }

        public void Draw()
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.Write("The triangle has it's corners at: ");

            for (int index = 0; index < NumberOfAngles; index++)
            {
                Console.Write($" {alphabet[index]}({Position[index].X},{Position[index].Y}), ");
            }

            Console.WriteLine($"The color of the triangle is: {Color}");
        }

        public void Scale(int scaling)
        {

        }

        public void TranslateToPoints()
        {
            
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitTriangle(this);
        }
    }
}