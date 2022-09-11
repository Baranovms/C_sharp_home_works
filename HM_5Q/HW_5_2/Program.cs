// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine();
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum += array[i];
    }
    return sum;
}

const int MIN_ELEMENTS = 0;
const int MAX_ELEMENTS = 99;

int length = Prompt("Введите длину массива: ");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
Console.WriteLine($"Сумма нечетных позиций массива равна {SumOddElements(array)}");