// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double Prompt(string message)
{
    Console.Write(message);
    bool isDigit = double.TryParse(Console.ReadLine(), out double number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

double[] PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double[] coord = new double[2];
    coord[0] = (b2 - b1) / (k1 - k2);
    coord[1] = k1 * coord[0] + b1;
    return coord;
}

double b1 = Prompt("Введите значение аргумента b для 1 уравнения:");
double k1 = Prompt("Введите значение аргумента k для 1 уравнения:");
double b2 = Prompt("Введите значение аргумента b для 2 уравнения:");
double k2 = Prompt("Введите значение аргумента k для 2 уравнения:");
double[] answer = PointOfIntersection(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения прямых y={k1}*x + {b1} и y={k2}*x + {b2} имеет координаты ({answer[0]}, {answer[1]})");