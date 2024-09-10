using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai3
    {
        public static void Main(string[] args)
        {
            // Nhập mảng từ người dùng
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Tìm phần tử lớn nhất
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            // In kết quả
            Console.WriteLine("Phần tử lớn nhất trong mảng là: " + max);
        }
    }
}
