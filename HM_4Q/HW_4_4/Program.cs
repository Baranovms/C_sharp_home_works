// (*) Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
// 8 1 2 4 4 5 3 1 -> 5
// 1 2 6 9 8 1 1 1 -> 8
// 2 1 2 1 1 1 1 1 -> 1
// 1 2 1 2 1 1 1 1 -> 1
// 1 2 3 4 5 6 7 8 -> 7
// 1 2 3 4 5 6 8 7 -> 7

//!!!!еще в процессе !!!!!!

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
    int index1 = 0;
    int temp = 0;
    int max1 = array[0];
    int max2 = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max1 = array[i];
            index1 = i;
            max2 = max1;
            array[0] = max1;
        }
        // temp = array[index1];
        // array[index1] = array[0];
        // array[0] = temp;
        System.Console.Write($"{array[i]} ");
        if (array[i] > array[index1])
        {
            max2 = array[i];
            if (max2 != max1)
            {

            }

        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Первый максимум: {max1}");
    System.Console.WriteLine($"второй максимум: {max2}");
    System.Console.WriteLine($"Индекс Первый максимум: {index1}");

}

// int MaxArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[maxPosition])
//             {
//                 maxPosition = j;
//             }
//         }
//         int temp = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temp;
//     }
//     return array[maxPosition];
// }

PrintArray(CreateArray(8));

