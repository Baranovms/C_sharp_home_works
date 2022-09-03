// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Prompt(string message)
{
    System.Console.Write(message);       
    string strValue;                      
    strValue = Console.ReadLine() ?? "0"; 
    int value = int.Parse(strValue);
    return value;
}

int value = Prompt("Введите трехзначное число: ");
if ((value < 1000) && (value > 99))
{
    int secondChar = (value / 10) % 10;
    System.Console.WriteLine($"Среднее значение числа {value} равно {secondChar}");
}
else
{
    System.Console.WriteLine("Число не является трехзначным");
}


