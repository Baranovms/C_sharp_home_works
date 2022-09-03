// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message);       
    string strValue;                      
    strValue = Console.ReadLine() ?? "0"; 
    int value = int.Parse(strValue);
    return value;
}

int value = Prompt("Введите число: ");
if ((value <= 99))
  {
    Console.WriteLine($"Введенное число {value} не имеет третьей цифры");
  }
if ((value < 1000) && (value >= 100))
  {
    System.Console.WriteLine($"Введенное число {value}, его третья цифра равна {value % 10}");  
  }
if ((value < 10000) && (value >= 1000))
  {
    System.Console.WriteLine($"Введенное число {value}, его третья цифра равна {(value / 10) % 10}");
  }
if ((value < 100000) && (value >= 10000))
  {
    System.Console.WriteLine($"Введенное число {value}, его третья цифра равна {(value / 100) % 10}");
  }
if ((value < 1000000) && (value >= 100000))
  {
    System.Console.WriteLine($"Введенное число {value}, его третья цифра равна {(value / 1000) % 10}");
  }