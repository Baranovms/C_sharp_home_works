﻿// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

Console.Clear();
int row = 2;
int col = 3;
int min = 1;
int max = 10;

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine();
}

int[,] GetTable(int row, int col, int min, int max)
{
    int[,] table = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            table[i, j] = new Random().Next(min, max + 1);
        }
    }
    return table;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            System.Console.Write(tab[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int SumRow(int[,] arr)
{
    int i = 0;
    int Max = 0;
    int sumRow = 0;
    while (i < row)
    {
        for (int j = 0; j < col; j++)
        {
            if (arr[i, j] > Max)
            {
                Max = arr[i, j];
            }
        }
        sumRow += Max;
        Max = 0;
        i++;
    }
    return sumRow;
}



int[,] arr = GetTable(row, col, min, max);
PrintTable(arr);
System.Console.WriteLine($"Построчная сумма максимальных значений: {SumRow(arr)}");
