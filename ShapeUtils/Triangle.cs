using System;
using System.Collections.Generic;

namespace ShapeUtils
{
    public class Triangle : Shape, ITriangle, IEquatable<ITriangle>
    {
        public (double A, double B, double C) Sides { get; set; }

        public Triangle(double a, double b, double c) : this((a, b, c)) {}
        
        public Triangle((double a, double b, double c) sides)
        {
            Name = "Triangle";
            Sides = sides;
        }

        public override double GetSquare()
        {
            // для прямоугольного треуголника такой вариант получится точнее
            if(IsRightAngled())
            {
                var list = GetOrderedSides();
                return list[0] * list[1] / 2.0;
            }
            
            var p = (Sides.A + Sides.B + Sides.C) / 2.0;            
            return Math.Sqrt(p * (p - Sides.A) * (p - Sides.B) * (p - Sides.C));
        }

        public bool IsRightAngled()
        {
            var list = GetOrderedSides();
            return list[2] * list[2] == list[1] * list[1] + list[0] * list[0];
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Name, IsRightAngled() ? " (Right-Angled)" : "");
        }

        private List<double> GetOrderedSides()
        {
            var list = new List<double>(3) {Sides.A, Sides.B, Sides.C};
            list.Sort();
            return list;
        }

        public bool Equals(ITriangle other)
        {
            if(other == null) return false;
            var currentSides = GetOrderedSides();
            var otherSides = new List<double>(3) {other.Sides.A, other.Sides.B, other.Sides.C};
            otherSides.Sort();
            for (int i = 0; i < currentSides.Count; i++)
                if(currentSides[i] != otherSides[i]) return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(this, obj)) return true;
            if(obj is ITriangle triangle) return Equals(triangle);
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = 871524205;
            hashCode = hashCode * -1521134295 + Sides.A.GetHashCode();
            hashCode = hashCode * -1521134295 + Sides.B.GetHashCode();
            hashCode = hashCode * -1521134295 + Sides.C.GetHashCode();
            return hashCode;
        }
    }
}
