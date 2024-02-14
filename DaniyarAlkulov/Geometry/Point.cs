namespace Geometry
{
    public class Point: IReflectable
    {
        public double _x; 
        public double _y;

        public double X() => _x;
        public double Y() => _y;

        public Point()
        {

        }

        public Point(double x)
        {
            _x = x; _y = 0;
        }

        public Point(double x, double y)
        {
            _x = x; _y = y;
        }

        

         public void ReflectX(double x)
        {
            _x = x;
            
        }

         public void ReflectY(double y)
        {
            _y = y;
            
        }
    }
}
