using System;
using System.Collections.Generic;
using System.Text;

namespace FSD_OOP
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
