namespace FSD_OOP
{
    public interface IVisitor
    {
        void VisitRectangle(Rectangle rectangle);
        void VisitCircle(Circle circle);
        void VisitSquare(Square square);

    }

}
