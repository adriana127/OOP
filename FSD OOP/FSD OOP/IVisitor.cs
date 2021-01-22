using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
