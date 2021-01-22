using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public class Rectangle : IPolygon
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public int NumberOfAngles => 4;

        public EColors Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Point2D> Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Area()
        {
            return Height * Width;
        }

        public void Draw()
        {
            Console.WriteLine($"The height is: {Height}, the width is: {Width}");
        }

        public void Scale(int scaling)
        {
            throw new NotImplementedException();
        }

        public void TranslateToPoints()
        {
            throw new NotImplementedException();
        }
    }
}
