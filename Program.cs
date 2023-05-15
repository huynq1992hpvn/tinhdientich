using System;

namespace dientich
{
    class Program
    {
        static void Main(string[] args)
        {
            float chieurong;
            float chieudai;
            Console.Write("Nhap chieu rong: ");
            chieurong = float.Parse(Console.ReadLine());
            Console.Write("nhap chieu dai: ");
            chieudai= float.Parse(Console.ReadLine());
            float dientich = chieurong * chieudai;
            Console.WriteLine("dientich la " + dientich);
        }
    }
}