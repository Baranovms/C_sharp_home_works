// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row = 2;     //ввод строк в матрице
int col = 2;     //ввод столбцов матрицы
int min = 0;     //минимальное значение в матрице
int max = 10;    // максимальное значение в матрице

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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] firstarray, int[,] secondarray)
{
    int[,] resultarray = GetMatrix(row, col, min, max);
    if (firstarray.GetLength(0) != secondarray.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
    }
    for (int i = 0; i < firstarray.GetLength(0); i++)
    {
        for (int j = 0; j < secondarray.GetLength(1); j++)
        {
            resultarray[i, j] = 0;
            for (int k = 0; k < firstarray.GetLength(1); k++)
            {
                resultarray[i, j] += firstarray[i, k] * secondarray[k, j];
            }
        }
    }
    return resultarray;
}

Console.Clear();

int[,] firstMatrix = GetMatrix(row, col, min, max);
int[,] secondMatrix = GetMatrix(row, col, min, max);
int[,] resultMatrix = MultiMatrix(firstMatrix, secondMatrix);
PrintMatrix(firstMatrix);
System.Console.WriteLine();
PrintMatrix(secondMatrix);
System.Console.WriteLine();
PrintMatrix(resultMatrix);