using System.Runtime.CompilerServices;

namespace Geometry;

//Your code here for Point:

public class Point
{
    private double _x;
    private double _y;

    public double X => _x;
    public double Y => _y;
     
    public Point(double x, double y) => (_x, _y) = (x, y);

    public override bool Equals(object obj)
    {
     var other = (Point)obj;
     return X == other.X && Y == other.Y;

    }
}