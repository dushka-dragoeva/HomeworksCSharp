namespace Shapes
{
    public class Rectangle : Shape, ICalculate
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
