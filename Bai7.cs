using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Bai7
    {
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }

            public void DisplayProductInfo()
            {
                Console.WriteLine($"{GetType().Name}: {Name}, Price: {Price:C}, Stock: {Stock}");
            }

            public void ApplyDiscount(decimal percentage)
            {
                Price -= Price * (percentage / 100);
            }

            public void Sell(int quantity)
            {
                if (IsInStock() && quantity <= Stock)
                {
                    Stock -= quantity;
                    Console.WriteLine($"Sold {quantity} {GetType().Name}(s).");
                }
                else
                {
                    Console.WriteLine("Not enough stock to sell.");
                }
            }

            public bool IsInStock()
            {
                return Stock > 0;
            }
        }

        public static void Main(string[] args)
        {
            var mobile = new Product { Name = "iPhone 14", Price = 888.88m, Stock = 15 };
            var laptop = new Product { Name = "Dell XPS 13", Price = 1000.01m, Stock = 18 };
            var accessory = new Product { Name = "USB-C Cable", Price = 18.87m, Stock = 8 };

            // Hiển thị thông tin sản phẩm
            mobile.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();

            // Bán sản phẩm
            mobile.Sell(3);
            laptop.Sell(1);
            accessory.Sell(10);

            // Kiểm tra tồn kho
            Console.WriteLine($"Is {mobile.Name} in stock? {mobile.IsInStock()}");
            Console.WriteLine($"Is {laptop.Name} in stock? {laptop.IsInStock()}");
            Console.WriteLine($"Is {accessory.Name} in stock? {accessory.IsInStock()}");

            // Áp dụng giảm giá
            mobile.ApplyDiscount(10);
            laptop.ApplyDiscount(5);
            accessory.ApplyDiscount(20);

            // Hiển thị thông tin sau giảm giá
            mobile.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();
        }
 

    }
}
