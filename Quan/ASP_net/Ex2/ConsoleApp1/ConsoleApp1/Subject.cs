using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Subject
    {
        public Subject()
        {

        }
        public string subJect { get; set; }
        public float Transcript { get; set; }
        public void display()
        {
            Console.WriteLine("Mon hoc: {0} - Diem: {1}",subJect,Transcript);
        }
    }
}
