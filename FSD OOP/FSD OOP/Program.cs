using System;
using System.Collections.Generic;

namespace FSD_OOP
{
    class Program
    {
        public static void GetComponent(List<IColoredShape> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
        public static List<IColoredShape> CreateShapes()
        {

            return new List<IColoredShape> { new Circle(3, Color.Black), new Rectangle(3, 5, Color.Black), new Square(4, Color.Black) };
        }
        static void Main(string[] args)
        {
            Visitor visitor = new Visitor();
            List<IColoredShape> shapesList = CreateShapes();



            Console.WriteLine("1.Create new shape.\n2.Get report.");
            var response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    {
                        Console.WriteLine("Create:\n1.Rectangle\n2.Square\n3.Circle\n4.Triangle ");
                        var shapeType = Console.ReadLine();
                        switch (shapeType)
                        {
                            case "1":
                                {
                                    Console.Write("Height");
                                    var height = Double.Parse(Console.ReadLine() ?? string.Empty);
                                    Console.Write("Width");
                                    var width = Double.Parse(Console.ReadLine() ?? string.Empty);

                                    shapesList.Add(new Rectangle(height, width, Color.Black));
                                    break;
                                }
                            case "2":
                                {
                                    Console.Write("Dimension");
                                    var height = Double.Parse(Console.ReadLine() ?? string.Empty);
                                    shapesList.Add(new Square(height, Color.Black));
                                    break;
                                }
                            case "3":
                                {
                                    Console.Write("Radius");
                                    var radius = Double.Parse(Console.ReadLine() ?? string.Empty);
                                    shapesList.Add(new Circle(radius, Color.Black));
                                    break;
                                }
                                //case 4:
                                // {​​
                                // Console.Write("Radius");
                                // double height = Console.Read();
                                // shapesList.Add(new Circle(height));
                                // break;
                                // }​​
                        }
                    }
                    break;
                case "2":
                    {
                        Program.GetComponent(shapesList, visitor);
                        visitor.CreateReport();
                        break;
                    }
            }

            Console.ReadLine();
        }
    }
}
