using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt3
{
    public class Rectangle : GeometricShape
    {
        public int length;
        public int width;

        public Rectangle()
        {

        }
        public Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
         }
        public int mutator
        {
            get => length;
            set { length = value; }
        }
        public int accessor
        {
            get => width;
            set { width = value; }
        }
        public override void computeArea()
        {
            Console.WriteLine("Dien tich hcn la:" + (length * width));
        }
        public override void show()
        {
            Console.WriteLine("Chieu dai la:" + length);
            Console.WriteLine("Chieu rong la:" + width);
        }
    }
}
