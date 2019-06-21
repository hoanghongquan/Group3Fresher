using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamental
{
    class Program
    {
        private static List<Student> dshs = new List<Student>();

        private static void Them()
        {
            Console.WriteLine("Nhap ten: ");
            string name = Console.ReadLine();
            Console.WriteLine("Gioi tinh Nam - 1,Nu - 0: ");
            int gender = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap email: ");
            string email = Console.ReadLine();

            Student student = new Student()
            {
                Name = name,
                Gender = gender == 1 ? Gender.Nam : Gender.Nu,
                Email = email
            };
            Subject sj = new Subject()
            {
                subJect = subject,
                Transcript = transcript
            };
            Console.WriteLine("Nhap mon hoc: ");
            string subject = Console.ReadLine();
            Console.WriteLine("Nhap Diem: ");
            float transcript = int.Parse(Console.ReadLine());
            student.AddSubject(subJect);
            dshs.Add(student);
        }
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
        }
    }
}
