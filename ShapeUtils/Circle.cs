using System;

namespace ShapeUtils
{
    public class Circle : Shape, ICircle, IEquatable<ICircle>
    {
        private double radius;
        public double Radius 
        { 
            get => radius; 
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Radius is incorrect");
                radius = value;
            } 
        }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"{Name} (Radius: {Radius:F2})";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (obj is ICircle circle) return Equals(circle);
            return false;
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }

        public bool Equals(ICircle other)
        {
            if (other == null) return false;
            return other.Radius == Radius;
        }
    }
}
