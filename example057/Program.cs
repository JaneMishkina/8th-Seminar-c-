/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример { 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза*/

int [,] InitMatrix(int rows, int columns)
{
int [,] matrix = new int [rows, columns];
Random rnd = new Random();

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix[i, j] = rnd.Next(0, 10);
}
}
return matrix;
}

void PrintMatrix(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}
}

Dictionary<int, int> Slovar = new Dictionary<int, int>();
int[,] matrix = InitMatrix(4, 4);
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if(Slovar.ContainsKey(matrix[i,j]))
Slovar[matrix[i,j]]++;
else
Slovar.Add(matrix[i,j], 1);
}
}

PrintMatrix(matrix);

foreach (var item in Slovar.OrderBy(x=>x.Key))
{
Console.WriteLine($"{item.Key} встречается {item.Value} раз");
}
