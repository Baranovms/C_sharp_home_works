// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetMatrix(int row, int col, int min, int max)
{
    double[,] table = new double[row, col];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            table[i, j] = rnd.NextDouble()*10;
        }
    }
    return table;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]:f3}\t");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int row = 3;
int col = 4;
int min = -10;
int max = 10;

double[,] arr = GetMatrix(row, col, min, max);
PrintMatrix(arr);