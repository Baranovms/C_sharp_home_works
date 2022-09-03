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
string valueText = Convert.ToString(value);
if (valueText.Length > 2)
{
  System.Console.WriteLine($"Введенное число {value}, его третья цифра равна {valueText[2]}");
}
else {
  Console.WriteLine($"Введенное число {value} не имеет третьей цифры");
}