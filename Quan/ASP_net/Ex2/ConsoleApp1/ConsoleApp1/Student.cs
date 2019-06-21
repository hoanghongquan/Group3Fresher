using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Student
    {
        public Student()
        {
            dsmonhoc = new List<Subject>();
        }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public List<Subject> dsmonhoc { get; set; }

        public void AddSubject(Subject subJect)
        {
            dsmonhoc.Add(subJect);
        }

        public void display()
        {
            Console.WriteLine("Ten: {0} - Gioi tinh: {1} - Email: {2}", Name, Gender, Email);
        }
    }
}
