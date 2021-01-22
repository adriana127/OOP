using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public interface IVisitor
    {
        void VisitRectangle(Rectangle rectangle);
        void VisitCircle(Circle circle);
        void VisitSquare(Square square);

    }

}
