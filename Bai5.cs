using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai5
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            bool isPalindrome = true;
            int left = 0, right = n - 1;

            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            Console.WriteLine("Mảng " + (isPalindrome ? "là" : "không phải là") + " đối xứng");
        }
    }
}
