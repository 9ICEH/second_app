using System;

namespace Sleduyuchaya
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
                    bool discount20PctAvailable, discount50PcAvalible;
                    {
                        const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500, // м.кв.
                                      MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000; // м.кв.
                        discount20PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                                 tileQuontiti < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;

                        discount50PcAvalible = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                    }
                    if (discount20PctAvailable)
                    {
                        discountPersentage = 20; // %
                    }
                    else
                    {
                        if (discount50PcAvalible)
                        {
                        discountPersentage = 50; // %
                        }
                        else
                        {
                        discountPersentage = 0; // %
                        }
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
