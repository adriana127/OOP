using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public class Circle:IColoredShape
    {      
        protected double Radius { get; set; }
        public EColors Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Tuple<double, double>> Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        List<Point2D> IColoredShape.Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public double Area()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }


        public void Scale(int scaling)
        {
            throw new NotImplementedException();
        }
    }
}
