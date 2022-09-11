// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//System.Console.WriteLine($"Число {number} возвели в степень {degree}: {Math.Pow(number, degree)}"); //самое простое решение



double number = Promt("Введите возводимое число: ");
double degree = Promt("Введите степень: ");
System.Console.WriteLine($"Число {number} возвели в степень {degree}: {stepen(number)}");

double stepen(double number)
{
    double newNumber = 1;
    for (int i = 0; i < degree; i++)
    {
        newNumber = number * newNumber;
    }
    return newNumber;
}