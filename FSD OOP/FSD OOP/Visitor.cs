using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public class Visitor : IVisitor
    {
        public int NoCircles = 0;
        public int NoRectangle = 0;
        public int NoSquare = 0;
        public int NoTriangles = 0;

        public void VisitCircle(Circle circle)
        {
            NoCircles++;
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            NoRectangle++;
        }

        public void VisitSquare(Square square)
        {
            NoSquare++;
        }
        public void VisitTriangle(Triangle triangle)
        {
            NoTriangles++;
        }
        public void GetNumberOfCircles()
        {
            Console.WriteLine("Number of circles: " + NoCircles);
        }

        public void GetNoRectangle()
        {
            Console.WriteLine("Number of rectangles: " + NoRectangle);
        }

        public void GetNoSquare()
        {
            Console.WriteLine("Number of squares: " + NoSquare);
        }
        public void GetNoTriangles()
        {
            Console.WriteLine("Number of triangles: " + NoTriangles);
        }

        public void CreateReport()
        {
            GetNumberOfCircles();
            GetNoRectangle();
            GetNoSquare();
            GetNoTriangles();
        }
    }
}