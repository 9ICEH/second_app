using System;

namespace MnohcestVetvlenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string countryCode;
            decimal tileQuontiti, tilePrice;
            {
                const string COUNTRY_CODES =
                    "Азейбарджан (994) | Киргизия (996) | Таджикистан (992)\n" +
                    "Армения     (374) | Латвия   (371) | Туркмения   (993)\n" +
                    "Беларусь    (375) | Литва    (370) | Узбекистан  (998)\n" +
                    "Грузия      (995) | Молдова  (373) | Украины     (380)\n" +
                    "Казахстан   (007) | Россия   (007) | Эстония     (372)\n" +
                    "- - - - - - - - - - - - - - - - - - - - - - - - - - - -";

                Console.WriteLine(COUNTRY_CODES);

                Console.Write("Телефонные коды страны : ");
                countryCode = Console.ReadLine();

                Console.Write("Колличество плитки     : ");
                string stingTileQuontiti = Console.ReadLine();
                tileQuontiti = Convert.ToDecimal(stingTileQuontiti);

                Console.Write("Цена за 1 м.кв. плитки : ");
                string stingTilePrice = Console.ReadLine();
                tilePrice = Convert.ToDecimal(stingTilePrice);
            } // Принять ввод от пользователя

            decimal rate;
            {
                const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                             GEORGIA_CODE = "995", KAZAHSTAN_CODE = "008", KYRGYZSTAN_CODE = "996",
                             LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                             RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                             UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                if (countryCode == AZERBAIJAN_CODE)
                {
                    const decimal AZERBAIJAN_RATE = 1.07m;
                    rate = AZERBAIJAN_RATE;
                }
                else if (countryCode == ARMENIA_CODE)
                {
                    const decimal ARMENIA_RATE = .95m;
                    rate = ARMENIA_RATE;
                }
                else if (countryCode == BELARUS_CODE)
                {
                    const decimal BELARUS_RATE = 1m;
                    rate = BELARUS_RATE;
                }
                else if (countryCode == GEORGIA_CODE)
                {
                    const decimal GEORGIA_RATE = .94m;
                    rate = GEORGIA_RATE;
                }
                else if (countryCode == KAZAHSTAN_CODE)
                {
                    const decimal KAZAHSTAN_RATE = .79m;
                    rate = KAZAHSTAN_RATE;
                }
                else if (countryCode == KYRGYZSTAN_CODE)
                {
                    const decimal KYRGYZSTAN_RATE = .83m;
                    rate = KYRGYZSTAN_RATE;
                }
                else if (countryCode == LATVIA_CODE)
                {
                    const decimal LATVIA_RATE = 1.12m;
                    rate = LATVIA_RATE;
                }
                else if (countryCode == LITHUANIA_CODE)
                {
                    const decimal LITHUANIA_RATE = 1.12m;
                    rate = LITHUANIA_RATE;
                }
                else if (countryCode == MOLDOVA_CODE)
                {
                    const decimal MOLDOVA_RATE = .97m;
                    rate = MOLDOVA_RATE;
                }
                else if (countryCode == RUSSIA_CODE)
                {
                    const decimal RUSSIA_RATE = 1m;
                    rate = RUSSIA_RATE;
                }
                else if (countryCode == TAJIKISTAN_CODE)
                {
                    const decimal TAJIKISTAN_RATE = .76m;
                    rate = TAJIKISTAN_RATE;
                }
                else if (countryCode == TURKMENISTAN_CODE)
                {
                    const decimal TURKMENISTAN_RATE = .81m;
                    rate = TURKMENISTAN_RATE;
                }
                else if (countryCode == UZBEKISTAN_CODE)
                {
                    const decimal UZBEKISTAN_RATE = .98m;
                    rate = UZBEKISTAN_RATE;
                }
                else if (countryCode == UKRAINE_CODE)
                {
                    const decimal UKRAINE_RATE = 1m;
                    rate = UKRAINE_RATE;
                }
                else if (countryCode == ESTONIA_CODE)
                {
                    const decimal ESTONIA_RATE = 1.12m;
                    rate = ESTONIA_RATE;
                }
                else
                {
                    rate = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели несуществующтий код: {countryCode}!");
                }
            }

            decimal tilePriceWithRate = tilePrice * rate;
            decimal tileCost = tileQuontiti * tilePriceWithRate; // руб.
            
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
                    else if(discount50PcAvalible)
                    {
                        discountPersentage = 50; // %
                    }
                    else
                    {
                        discountPersentage = 0; // %
                }
            } // Определить процент скидки
                discount = tileCost / 100 * discountPersentage;
            }
            decimal paymentAmount = tileCost - discount;

            Console.WriteLine($"Цена с коэфициентом    : {tilePriceWithRate} руб.");
            Console.WriteLine($"Общая стоимость плитки : {tileCost} руб.");
            Console.WriteLine($"Скидка                 : {discount} руб.");
            Console.WriteLine($"Сумма к оплате         : {paymentAmount} руб.");

            // Delay
            Console.ReadKey();
        }
    }
}
