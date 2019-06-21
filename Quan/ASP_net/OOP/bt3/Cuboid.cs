using System;
using System.Collections.Generic;
using System.Text;

namespace bt3
{
    class Cuboid : Rectangle
    {
        public int height;
        public int getheight
        {
            get => height;
        }
        public int setheight
        {
            set { height = value; }
        }
        public Cuboid(int length,int width,int height)
        {
            base.length = length;
            base.width = width;
            this.height = height;
        }
        public override void computeArea()
        {
            Console.WriteLine("The tich la: "+(height*length*width);
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("Height: " + height);
        }
    }
}
