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
            List<IColoredShape> shapesList = new List<IColoredShape>(); // CreateShapes();

            while (true)
            {
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
                                        double height = Double.Parse(Console.ReadLine() ?? string.Empty);
                                        Console.Write("Width");
                                        double width = Double.Parse(Console.ReadLine() ?? string.Empty);

                                        shapesList.Add(new Rectangle(height, width, Color.Black));
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.Write("Dimension");
                                        double height = Double.Parse(Console.ReadLine() ?? string.Empty);
                                        shapesList.Add(new Square(height, Color.Blue));
                                        break;
                                    }
                                case "3":
                                    {
                                        Console.Write("Radius");
                                        double radius = Double.Parse(Console.ReadLine() ?? string.Empty);
                                        shapesList.Add(new Circle(radius, Color.Green));
                                        break;
                                    }
                                case "4":
                                    {
                                        Console.Write("Left Corner: x1=");
                                        double x1 = Double.Parse(Console.ReadLine() ?? string.Empty);
                                        Console.Write("y1=");

                                        double y1 = Double.Parse(Console.ReadLine() ?? string.Empty);


                                        Console.Write("Right Corner: x2=");
                                        double x2 = Double.Parse(Console.ReadLine() ?? string.Empty);
                                        Console.Write("y2=");

                                        double y2 = Double.Parse(Console.ReadLine() ?? string.Empty);


                                        Console.Write("Last Corner: x3=");
                                        double x3 = Double.Parse(Console.ReadLine() ?? string.Empty);
                                        Console.Write("y3=");

                                        double y3 = Double.Parse(Console.ReadLine() ?? string.Empty);

                                        var p1 = new Point2D(x1,y1);
                                        var p2 = new Point2D(x2,y2);
                                        var p3 = new Point2D(x3,y3);

                                        shapesList.Add(new Triangle(p1,p2,p3, Color.Red));
                                        break;
                                    }
                            }
                            break;
                        }

                    case "2":
                        {
                            visitor = new Visitor();
                            GetComponent(shapesList, visitor);
                            visitor.CreateReport();

                            foreach (var shape in shapesList)
                            {
                                Console.WriteLine("-----------------------------------------------------");
                                Console.WriteLine($"Name: {shape.GetType().Name}");
                                Console.WriteLine($"Area: {shape.Area()}");
                                shape.Draw();
                                Console.WriteLine("Add 3 at Scale.");
                                shape.Scale(3);
                                shape.Draw();

                                Console.WriteLine();
                                Console.WriteLine();
                            }

                            break;
                        }
                }
            }
        }


    }
}
