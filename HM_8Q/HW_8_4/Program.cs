// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] GenerateSpiralMatrix(int len)
{
    int[,] table = new int[len, len];
    int number = 1;
    for (int i = 0; i < len/2; i++)
    {
        for (int j = i; j < len - i; j++)
        {
            table[i,j] = number++;
        }
        for (int k = i + 1; k < len - i; k++)
        {
            table[k,len - 1 - i] = number++;
        }
        for (int j = len - i -2; j >= i; j--)
        {
            table[len - 1 - i,j] = number++;
        }
        for (int k = len - 2 - i; k > i; k--)
        {
            table[k,i] = number++;
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
            if (matr[i, j] < 10)
            {
                Console.Write("0" + matr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


Console.Clear();
int rowandcol = Prompt("Введите размер матрицы: ");
int[,] matrix = GenerateSpiralMatrix(rowandcol);
PrintMatrix(matrix);