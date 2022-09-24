// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] CreateTripleMatrix(int row, int col, int plane, int min, int max)
{
    int[,,] table = new int[row, col, plane];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < plane; k++)
            {
                table[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return table;
}

void PrintTripleMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i}, {j}, {k})  ");
            }
        }
        System.Console.WriteLine();
    }
}


Console.Clear();

int row = 2;     //ввод строк в матрице
int col = 2;     //ввод столбцов матрицы
int plane = 2;   //ввод слоев матрицы
int min = 10;     //минимальное значение в матрице
int max = 100;    // максимальное значение в матрице

int[,,] tripleMatrix = CreateTripleMatrix(row, col, plane, min, max);
PrintTripleMatrix(tripleMatrix);
