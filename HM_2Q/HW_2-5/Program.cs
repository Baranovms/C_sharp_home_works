// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да
int Prompt(string message)
{
    System.Console.Write(message);       
    string strValue;                      
    strValue = Console.ReadLine() ?? "0"; 
    int value = int.Parse(strValue);
    return value;
}

int kratn = Prompt("Введите параметр кратности: ");
while (true)
{
    int numb = new Random().Next(1000);
    if (numb % kratn != 0)
    {
        System.Console.WriteLine($"Значение {numb} не кратно {kratn}");
    }
    else
    {
       System.Console.WriteLine($"Значение {numb} кратно {kratn}"); 
       break;
    }
}