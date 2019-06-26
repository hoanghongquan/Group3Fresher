using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    class Program
    {

        static void Main(string[] args)
        {
            Hocsinh hs;
            Monhoc mh = new Monhoc();
            while (true)
            {
                hs = new Hocsinh();
                Console.WriteLine("Name:");
                hs.Name = Console.ReadLine();
                Console.WriteLine("gioitinh:");
                hs.Gioitinh = Console.ReadLine();
                Console.WriteLine("Email:");
                hs.Email = Console.ReadLine();

                Console.WriteLine("ten mon hoc:");
                mh.Tenmonhoc = Console.ReadLine();

                nhapLai:
                Console.WriteLine("diem:");
                try
                {
                    mh.Diem = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    goto nhapLai;
                }


                Console.WriteLine("ban muon nhap tiep hay k? Y/N");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.Equals("no") || yesOrNo.Equals("N") || yesOrNo.Equals("n"))
                {
                    Console.WriteLine("Thong tin hoc sinh:");
                    Console.WriteLine("ten: {0}", hs.Name);
                    Console.WriteLine("gioi tinh:{0}", hs.Gioitinh);
                    Console.WriteLine("email:{0} ", hs.Email);
                    Console.WriteLine("ten mon hoc:{0} ", mh.Tenmonhoc);
                    Console.WriteLine("diem:{0} ", mh.Diem);
                    Console.ReadKey();
                    return;
                }

            }
        }

        

        }
            

            
            //  hs.Name = Console.ReadLine();
            // hs.Gioitinh = Console.ReadLine();
            // hs.Email = Console.ReadLine();
            //if()
            //mh.Tenmonhoc = Console.ReadLine();
       
        }



    


