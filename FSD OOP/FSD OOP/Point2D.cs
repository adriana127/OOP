﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public class Point2D
    {
        public Point2D()
        {
        }
        public Point2D(double X, double Y)
        {
            this.X = X;
            this.Y = Y;

        }
        public double X { get; set; }
        public double Y { get; set; }

    }
}
