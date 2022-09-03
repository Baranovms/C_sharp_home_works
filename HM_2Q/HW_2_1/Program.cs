// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.Write("Введите трехзначное число: ");
string value = Console.ReadLine();
if (value.Length == 3)
{
    char secondChar = value[value.Length-2];
    System.Console.WriteLine($"Среднее значение числа {value} равно {secondChar}");
}
else
{
    System.Console.WriteLine("Введенное значение вне диапазона");
}
