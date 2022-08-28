//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

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
int third = Prompt("Введите третье число: ");
if ((first == second) && (first == third))
{
    System.Console.WriteLine("Значения равны");
}
else
{
    if ((first == second) || (first == third) || (second == third))
    {
        System.Console.WriteLine("Есть равные пары чисел");
    }
    else
    {
        if ((first > second) & (first > third))
        {
            System.Console.WriteLine($"Максимальное значение из {first}, {second}, {third} равняется {first}");
        }
        else
        {
            if (second > third)
            {
                System.Console.WriteLine($"Максимальное значение из {first}, {second}, {third} равняется {second}");
            }
            else
            {
                System.Console.WriteLine($"Максимальное значение из {first}, {second}, {third} равняется {third}");
            }
        }
    }
}
