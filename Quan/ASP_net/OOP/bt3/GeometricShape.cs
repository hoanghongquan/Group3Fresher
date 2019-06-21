using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt3
{
    public class GeometricShape
    {
        public string shapeType;
        public double area;
        public GeometricShape()
        {
            this.shapeType = "NoShape";
            this.area = 0.0;
        }
        public virtual void computeArea()
        {

        }
        public virtual void show()
        {
            Console.WriteLine("ShapeType: " +shapeType);
            Console.WriteLine("Area: " +area);
        }
    }
}
