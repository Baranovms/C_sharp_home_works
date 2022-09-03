//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int Prompt(string message)
{
    System.Console.Write(message);       
    string strValue;                      
    strValue = Console.ReadLine() ?? "0"; 
    int value = int.Parse(strValue);
    return value;
}

int numberDay = Prompt("Введите номер дня недели: ");
if (numberDay < 1 || numberDay > 7) 
{
    Console.WriteLine("это не день недели");
}
else
{
    if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine($"{numberDay} - это ВЫХОДНОЙ день");
    }
    else
    {
        Console.WriteLine($"{numberDay} - это РАБОЧИЙ день");
    }
}