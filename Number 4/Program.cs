using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ca1, Ca2, Gip, Si, St;
            Console.WriteLine("Введите катет: ");
            Ca1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите гипотенузу: ");
            Gip = double.Parse(Console.ReadLine());
            Ca2 = (Math.Sqrt((Gip * Gip) - (Ca1 * Ca1)));
            Console.WriteLine("Второй катет=" +Ca2);
            Si = (Ca2 / Gip);
            St = (0.5 * Ca1 * Gip * Si);
            Console.WriteLine("Площадь треугольника=" + St);
        }
    }
}
