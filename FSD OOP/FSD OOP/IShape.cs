using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public interface IShape
    {
        void Draw();
        void Scale(int scaling);
        double Area();
    }
}
