namespace FSD_OOP
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
