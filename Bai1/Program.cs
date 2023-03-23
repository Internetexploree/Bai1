using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Le Phu Qui
            Console.Write("Moi nhap gia tri a: ");
            int a = Int16.Parse(Console.ReadLine());

            Console.Write("Moi nhap gia tri b: ");
            int b = Int16.Parse(Console.ReadLine());

            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            float thuong = (float)a / b;
            Console.WriteLine("Tong cua a va b la: {0} ", +tong);
            Console.WriteLine("Hieu cua a va b la: {0} ", +hieu);
            Console.WriteLine("Tich cua a va b la: {0} ", +tich);
            Console.WriteLine("Thuong cua a va b la: {0} ", +thuong);
            Console.ReadLine();
        }
    }
}
