// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100,1000);
int new_numb = int.Parse(number.ToString().Remove(1, 1));
Console.WriteLine($"Введенное значение {number} после удаления второго значение {new_numb}");
