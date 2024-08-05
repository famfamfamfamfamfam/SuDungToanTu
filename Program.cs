using System;
namespace SUDUNGTOANTU
{
    class TinhDienTich
    {
        static void Main(string[] args)
        {
            float chieucao;
            float chieurong;
            float dientich;
            Console.WriteLine("Nhap chieu cao hinh chu nhat:");
            chieucao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong hinh chu nhat:");
            chieurong = float.Parse(Console.ReadLine());
            dientich = chieucao * chieurong;
            Console.WriteLine("Dien tich hinh chu nhat: {0} * {1} = {2}", chieucao, chieurong, dientich);
        }
    }
}