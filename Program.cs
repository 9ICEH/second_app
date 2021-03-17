using System;

namespace Vetvlenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
          
            // 1. запросить у кассира, ввести колличество плитки в метрах квадратных,
            // цену плитки за квадратный метр
            uint quontiti, price;
            {
                Console.Write("Колличество плитки:");
                quontiti = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Цена за 1 м.кв. плитки:");
                price = Convert.ToUInt32(Console.ReadLine());
            }
            // 2. посчитать общую стоимость плитки
            decimal cost = quontiti * price; // rub
            // 3. посчитать сумму скидки в 10 %
            decimal discount;
            {
                const decimal DISCOUNT_PERSENTAGE = 10; // %
                discount = cost / 100 * DISCOUNT_PERSENTAGE;
            }
            // 4. посчитать сумму к олате с учетом скидки
            decimal paymentAmount = cost - discount;
            // 5. вывести на экран: общую стоимость, сумму скидки и сумму к оплате
            Console.WriteLine($"Общая стоимость плитки: {cost} rub.");
            Console.WriteLine($"Скидка                : {discount} rub.");
            Console.WriteLine($"Сумма к оплате        : {paymentAmount} rub.");

            // Delay
            Console.ReadKey();
        }
    }
}
