using System;

namespace GiaiPTBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CT GIAI PT BAC NHAT");
            Console.WriteLine("PT Co dang 'a*x + b = 0', Vui long nhap cac tham so :");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("PT co nghiem la : {0}", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("PT co vo so nghiem !");
                }
                else
                {
                    Console.Write("PT vo nghiem !");
                }
            }
        }
    }
}
