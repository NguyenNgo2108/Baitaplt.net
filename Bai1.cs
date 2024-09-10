using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai1
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n]; // Tạo mảng có n phần tử

            // Nhập giá trị cho các phần tử trong mảng
            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Tính tổng các phần tử
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += arr[i];
            }

            // In kết quả
            Console.WriteLine("Tổng các phần tử trong mảng là: " + tong);
        }
    }
}
