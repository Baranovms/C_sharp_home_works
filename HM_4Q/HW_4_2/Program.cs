// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int num)
{
    int sumNumbers = 0;
    while (num > 0)
    {
        int digit = num % 10;
        sumNumbers += digit;
        num /= 10;
    }
    return sumNumbers;
}
int num = Promt("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {num} равна {SumDigit(num)}");

