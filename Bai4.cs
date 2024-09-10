using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai4
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string chuoi = Console.ReadLine();

            char[] charArray = chuoi.ToCharArray(); // Chuyển chuỗi thành mảng các ký tự
            Array.Reverse(charArray); // Đảo ngược mảng các ký tự

            string chuoiDaoNguoc = new string(charArray); // Tạo chuỗi mới từ mảng đã đảo ngược

            Console.WriteLine("Chuỗi đảo ngược: " + chuoiDaoNguoc);
        }
    }
}
