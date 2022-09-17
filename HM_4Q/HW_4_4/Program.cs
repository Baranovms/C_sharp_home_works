// (*) Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
// 8 1 2 4 4 5 3 1 -> 5
// 1 2 6 9 8 1 1 1 -> 8
// 2 1 2 1 1 1 1 1 -> 1
// 1 2 1 2 1 1 1 1 -> 1
// 1 2 3 4 5 6 7 8 -> 7
// 1 2 3 4 5 6 8 7 -> 7



Console.Clear();

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    int max1 = array[0];
    int max2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max1 < array[i])
        {
            max2 = max1;
            max1 = array[i];
        }
        else if (max1 != array[i] && max2 < array[i])
        {
            max2 = array[i];
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"второй максимум: {max2}");
}


PrintArray(CreateArray(8));

