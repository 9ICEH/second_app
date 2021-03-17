using System;

namespace operacii_nad_masivami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int numberOfTypeOfTile, numberOfTypesOfMaterials;
            {
                Console.Write("Введите количество разновидностей плитки        :  ");
                numberOfTypeOfTile = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество сырья для изготовления плитки:  ");
                numberOfTypesOfMaterials = Convert.ToInt32(Console.ReadLine());
            }

            //  в 1-м столбце кг песка, во 2-м кг глина, 1-3 строки типы плитки
            decimal[,] A = new decimal[3, 2]
            {
               { 5, 4 },  // Т1
               { 3, 7 },  // Т2
               { 2, 6 }   // Т3
            };

            decimal[,] B = new decimal[2, 1]
            {
               { 70 }, // цена за 1 кг песка
               { 50 }  // цена за 1 кг глины
            };

            decimal[] C = { 80, 140, 60 }; // к-во штук

            decimal[,] Z = new decimal[3, 1]; // выражение Z = А*В

            // Z подсчет общей стоимости материалов(A, D, C, Z)
            {
                for (int i = 0; i < A.GetLength(1); i++)
                    for (int j = 0; j < A.GetLength(1); j++)
                        Z[i, 0] += A[i, j] * B[j, 0];

                decimal P = 0;

                for (int i = 0; i < Z.GetLength(0); i++)
                    P += C[i] * Z[i, 0];

                Console.WriteLine($"Общая стоимость вырья = {P}");

            }

            // Delay
            Console.ReadKey();
        }
    }
}

