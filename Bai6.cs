using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai6
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string chuoi = Console.ReadLine();

            Console.Write("Nhập vào ký tự cần đếm: ");
            char kyTuCanDem = Console.ReadLine()[0];

            int dem = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == kyTuCanDem)
                {
                    dem++;
                }
            }

            Console.WriteLine("Ký tự '{0}' xuất hiện {1} lần trong chuỗi.", kyTuCanDem, dem);
        }
    }
}
