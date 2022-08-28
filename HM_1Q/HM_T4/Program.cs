// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}

int N = Prompt("Введите последнее значение в ряду: ");
System.Console.Write($"Чётные значения от 1 до {N}:");
for (int i = 1; i <= N; i++ )
{
    if (i % 2 != 1)
    {
        System.Console.Write(" " +i);
    }   
}