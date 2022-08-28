//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}

int first = Prompt("Введите первое число: ");
int second = Prompt("Введите второе число: ");
int max;
if (first != second)
{
    if (first > second)
    {
        max = first;
        System.Console.WriteLine($"Наибольшее значение из {first} и {second} равно: {max}");
    }
    else
    {
        max = second;
        System.Console.WriteLine($"Наибольшее значение из {first} и {second} равно: {max}");
    }
}
else
{
    System.Console.WriteLine("Введенные числа равны");
}