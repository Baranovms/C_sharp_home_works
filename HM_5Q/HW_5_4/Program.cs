// Задача со звездочкой: Сформировать массив четной длины с парами элементов, каждого элемента должно быть в паре,
// 1,1,2,3,3,2,4,5,4,5

Console.Clear();

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
    for (int i = 0; i < answer.Length-1; i = i+2)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);;
        answer[i+1] = answer[i];
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

int length = Prompt("Введите длину массива: ");
if (length % 2 == 0)
{
    int minRandom = Prompt("Введите минимально возможный элемент массива: ");
    int maxRandom = Prompt("Введите максимально возможный элемент массива: ");
    int[] array = GenerateArray(length, minRandom, maxRandom);
    PrintArray(array);
}
else
{
    Console.WriteLine("Вы ввели нечетную длину массива");
}

