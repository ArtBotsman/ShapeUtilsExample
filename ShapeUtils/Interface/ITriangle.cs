namespace ShapeUtils
{
    
    public interface ITriangle
    {
        (double A, double B, double C) Sides { get; }

        bool IsRightAngled();
    }
}