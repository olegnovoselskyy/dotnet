namespace Polygons.Library
{
    public class Square : AbstractRegularPolygon
    {
        public Square(int length) :
            base(4, length)
        { }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
