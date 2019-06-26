using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplab3
{
    class GeometricShape
    {
        public string shapeType;
        public double area;
   
        public GeometricShape()
        {
            this.shapeType = "NoShape";
            this.area = 0.0;

        }
        public virtual double computArea()
        {
            return this.area;
        }
        public virtual void show()
        {
            Console.WriteLine("shapeType:" + shapeType);
            Console.WriteLine("area:" + area);
            Console.WriteLine("computArea:" + computArea());
        }
    }
}
