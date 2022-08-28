//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}

int first = Prompt("Введите число: ");
if (first % 2 == 0)
{
    System.Console.WriteLine($"Введенное значение {first} - чётное");
}
else
{
    System.Console.WriteLine($"Введенное значение {first} - нечётное");
}