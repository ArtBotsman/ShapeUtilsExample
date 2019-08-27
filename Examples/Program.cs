using System;
using System.Linq;
using System.Collections.Generic;
using ShapeUtils;


namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ShapeUtils examples");

            var listOfShapes = new List<Shape>(4);

            listOfShapes.Add(new Circle(1.1));
            listOfShapes.Add(new Triangle(3, 4, 5));
            listOfShapes.Add(new Triangle(4, 4, 7));
            listOfShapes.Add(new Circle(22));

            foreach(var s in listOfShapes)
                Console.WriteLine("{0} square is {1:F6}", s, s.GetSquare());
        }
    }
}
