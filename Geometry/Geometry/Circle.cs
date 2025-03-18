using Geometry;

public class Circle
{
    public Point _center;
    public double _radius;


    public Point Center => _center;
    public double Radius => _radius;

    public Circle(double radius, Point center)
    {
        _radius = radius;
        _center = center;
    }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area
    {
        get
        {
            return Math.PI * Radius * Radius;
        }
    }

    public bool? BelongsToCircle(Point point)
    {
        if (Center == null)
            return null;

        return (point.X <= Center.X + Radius && point.Y <= Center.Y + Radius) ? true : false;
    }
}