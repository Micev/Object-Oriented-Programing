using System;
using System.Collections.Generic;

namespace Shapes
{
    class TestShape
    {
        public static void Main()
        {
            IShape tr = new Triangle(4, 3);
            IShape rec = new Rectangle(4, 6);
            IShape circle = new Circle(5);

            List<IShape> listShapes = new List<IShape>()
            {
                tr,
                rec,
                circle
            };

            foreach (var item in listShapes)
            {
                Console.WriteLine(item.GetType().Name + " --> Area: " + item.CalculateArea());
                Console.WriteLine(item.GetType().Name + " --> Perimeter: " + item.CalculatePerimeter());
            }
        }
    }
}
