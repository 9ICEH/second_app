using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal tileQuontiti, tilePrice;
            {
            Console.Write("Колличество плитки     : ");
            string stingTileQuontiti = Console.ReadLine();
            tileQuontiti = Convert.ToDecimal(stingTileQuontiti);

            Console.Write("Цена за 1 м.кв. плитки : ");
            string stingTilePrice = Console.ReadLine();
            tilePrice = Convert.ToDecimal(stingTilePrice);
            } // Принять ввод от пользователя

        decimal tileCost = tileQuontiti * tilePrice; // rub
            
        decimal discount; // rub
        {
            decimal discountPersentage; // %
            {
                const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500; // м.кв.
                bool discount20PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT;

                if (discount20PctAvailable)
                {
                    discountPersentage = 20; // %
                }
                else
                {
                    discountPersentage = 10; // %
                }
            } // Определить процент скидки
                discount = tileCost / 100 * discountPersentage;
        }
        decimal paymentAmount = tileCost - discount;

        Console.WriteLine($"Общая стоимость плитки : {tileCost} руб.");
        Console.WriteLine($"Скидка                 : {discount} rub.");
        Console.WriteLine($"Сумма к оплате         : {paymentAmount} rub.");

        // Delay
        Console.ReadKey();
        }
    }
 }
