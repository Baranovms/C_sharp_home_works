// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int value = new Random().Next(100, 1000);
int  newValue = 0;

newValue = value / 100 * 10 + value % 10;

System.Console.WriteLine($"Заданное значечение {value} преобразуется в {newValue}");

