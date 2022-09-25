// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

void SumNumbers(int startValue, int finishVAlue, int summ)
{
    if (startValue > finishVAlue)
    {
        System.Console.WriteLine($"Сумма элементов равна: {summ}");
        return;
    }
    summ = summ + (startValue++);
    SumNumbers(startValue, finishVAlue, summ);
}

int first = Prompt("Введите начальное число: ");
int second = Prompt("Введите конечное число: ");
SumNumbers(first, second,0);
