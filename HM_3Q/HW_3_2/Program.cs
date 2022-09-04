// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

const int XCOORD = 0;
const int YCOORD = 1;
const int ZCOORD = 2;


int Prompt(string message)
{
    System.Console.Write(message);       
    return Convert.ToInt32(Console.ReadLine());
}

int[] InsertCoords()
{
    int[] temp = new int[3];
    temp[XCOORD] = Prompt("Введите координату Х: ");
    temp[YCOORD] = Prompt("Введите координату Y: ");
    temp[ZCOORD] = Prompt("Введите координату Z: ");

    return temp;
}

double Lenght (int[] firstCoord, int[] secondCoord)
{
    return Math.Sqrt(Math.Pow(firstCoord[XCOORD]-secondCoord[XCOORD],2) + Math.Pow(firstCoord[YCOORD]-secondCoord[YCOORD],2)+Math.Pow(firstCoord[ZCOORD]-secondCoord[ZCOORD],2));
}


int[] firstPoint = InsertCoords();
int[] secondPoint = InsertCoords();
System.Console.WriteLine($"Расстояние между двумя точками: {Lenght(firstPoint,secondPoint):f2}");