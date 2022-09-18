// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] table = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            table[i, j] = new Random().Next(min, max);
        }
    }
    return table;
}

double[] AverageNumber(int[,] matrix)
{
    double[] avgNumb = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result += matrix[j, i];
        }
        avgNumb[i] = result / matrix.GetLength(0);
    }
    // PrintArray(avgNumb);
    return avgNumb;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}" + "; ");
    }
    System.Console.WriteLine();
}

Console.Clear();
int row = 3;
int col = 4;
int min = 0;
int max = 10;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
System.Console.WriteLine("------------------------------");
System.Console.Write($"Среднее арифметическое каждого столбца равно: ");
PrintArray(AverageNumber(matrix));