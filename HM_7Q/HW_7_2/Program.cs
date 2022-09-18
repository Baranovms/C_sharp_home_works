// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

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

Console.Clear();
int row = 3;
int col = 4;
int min = 0;
int max = 10;

int[,] arr = GetMatrix(row, col, min, max);
PrintMatrix(arr);

int searchRow = Prompt("Введите строку:");
int searchCol = Prompt("Введите столбец:");
if (searchRow - 1 < arr.GetLength(0) && searchCol - 1 < arr.GetLength(1))
{
    System.Console.WriteLine($"В позиции {searchRow}, {searchCol} находится значение: {arr[searchRow - 1, searchCol - 1]}");
}
else
{
    System.Console.WriteLine($"{searchRow}, {searchCol} -> Такого числа в массиве нет");
}