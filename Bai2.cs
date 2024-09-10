using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai2
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string chuoi = Console.ReadLine();

            int demKyTu = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                char kyTu = chuoi[i];
                if (char.IsLetterOrDigit(kyTu))
                {
                    demKyTu++;
                }
            }

            Console.WriteLine("Số lượng ký tự trong chuỗi là: " + demKyTu);
        }
    }
}
