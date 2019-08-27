using System;
using System.Linq;
using System.Collections.Generic;

namespace ShapeUtils
{
    ///<summary>
    ///The main shape class with the moust used operations
    ///</summary>
    public abstract class Shape
    {
        protected List<(double X, double Y)> Coordinates;

        ///<summary>
        ///Name of shape
        ///</summary>
        public string Name { get; protected set; } = "Shape";
        
        ///<summary>
        ///Calculate the square of the shape
        ///</summary>
        public virtual double GetSquare()
        {
            // фигура должна иметь не меньше 3 уникальных координат
            if(Coordinates == null) throw new NotImplementedException("You must override this method if don't use coordinates");

            var cords = Coordinates.Distinct().ToList();
            if(cords.Count < 3) throw new InvalidOperationException("This is not a shape");


            // если этот метод не переопределен
            // тогда придется использовать методы вычисления площади по координатам
            // например метод Монте-Карло 
            // для определения принадлежности точки фигуре можно использовать трассировку лучей 

            // TODO пока не реализовано

            return double.NaN;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}