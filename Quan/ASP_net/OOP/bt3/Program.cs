using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt3
{

    class Program
    {
        static void Main(string[] args)
        {
            GeometricShape gs = new GeometricShape();
            gs.show();
            Console.ReadKey();
            Rectangle r = new Rectangle(2,3);
            r.show();
            r.computeArea();
            Console.ReadKey();
            Cuboid c = new Cuboid(1,5,8);
            c.show();
            c.computeArea();
            Console.ReadKey();
        }
    }
}
