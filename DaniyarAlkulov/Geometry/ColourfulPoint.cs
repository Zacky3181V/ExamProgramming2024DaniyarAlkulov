using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public enum PointColour
    {
        Red, Green, Blue
    }
    internal class ColourfulPoint : Point
    {
        public PointColour Colour { get; }

        public ColourfulPoint(double x, double y, PointColour colour) : base(x, y)
        {
            Colour = colour;
        }
    }
}
