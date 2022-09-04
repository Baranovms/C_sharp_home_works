// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);       
    return Convert.ToInt32(Console.ReadLine());
}

void Palindrom (int number)
{
    int first = number / 10000;
    int second = number / 1000 % 10;
    int third = number / 100 % 10;
    int fourth = number / 10 % 10;
    int fifth = number % 10;
    if (first == fifth || second == fourth)
    {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else 
    {
        Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }
}

int number = Prompt("Введите пятизначное число: ");
Palindrom(number);
