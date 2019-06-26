using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplab3
{
    class Cuboid: Retangle
    {
        public Cuboid() { }
        public double height { get; set; }
        public void setHeigth(double Heigth)
        {
            this.height = Heigth;
        }
        public double  getHeigth()
        {
            return this.height;
        }
        public override double computArea()
        {
            return base.computArea() * height;
        }
        public override void show()
        {
            Console.WriteLine("--------Cuboid---------");
            base.show();
            Console.WriteLine("Heigth:" + height);
        }

    }
}
