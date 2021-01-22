using System;

namespace FSD_OOP
{
    public class Square : Rectangle
    {
        public Square(double height, Color color) : base(height, height, color)
        {
        }

        public new void Draw()
        {

            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.Write("The square has it's corners at: ");

            for (var index = 0; index < NumberOfAngles; index++)
            {
                Console.Write($" {alphabet[index]}({Position[index].X},{Position[index].Y}), ");
            }

            Console.WriteLine($"The color of the rectangle is: {Color}");
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitSquare(this);
        }

    }
}
