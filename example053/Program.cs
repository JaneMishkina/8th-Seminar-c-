/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

int GetNumber(string message)
        {
            int result = 0;

            while (true)
            {
                Console.WriteLine(message);

                if (int.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Такого элемента нет");
                }
            }

            return result;
        }

        int[,] InitMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(0, 100);
                }
            }

            return matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }


int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

        void SwapRows(int[,] matrix)
{
        int i = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            i = matrix[0,j];
            matrix[0,j] = matrix[matrix.GetLength(0)-1, j];
            matrix[matrix.GetLength(0)-1, j] = i;
        }
        }

SwapRows(matrix);
Console.WriteLine();
PrintMatrix(matrix);


