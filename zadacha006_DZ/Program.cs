/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = 0;
int y1 = 0;
int z1 = 0;
int x2 = 0;
int y2 = 0;
int z2 = 0;
bool needCoordinates = true;

while (needCoordinates)
{
    Console.WriteLine("Введите координаты первой точки A:");
    Console.Write("X: ");
    string x1fromConsole = Console.ReadLine();
    Console.Write("Y: ");
    string y1fromConsole = Console.ReadLine();
    Console.Write("Z: ");
    string z1fromConsole = Console.ReadLine();
    Console.WriteLine("Введите координаты второй точки B:");
    Console.Write("X: ");
    string x2fromConsole = Console.ReadLine();
    Console.Write("Y: ");
    string y2fromConsole = Console.ReadLine();
    Console.Write("Z: ");
    string z2fromConsole = Console.ReadLine();

    if    (int.TryParse(x1fromConsole, out int x1temp)
        && int.TryParse(y1fromConsole, out int y1temp)
        && int.TryParse(z1fromConsole, out int z1temp)
        && int.TryParse(x2fromConsole, out int x2temp)
        && int.TryParse(y2fromConsole, out int y2temp)
        && int.TryParse(z2fromConsole, out int z2temp))
    {
        needCoordinates = false;
        x1 = x1temp;
        y1 = y1temp;
        z1 = z1temp;
        x2 = x2temp;
        y2 = y2temp;
        z2 = z2temp;
    }
    else
    {
        Console.WriteLine("Ошибка! Введите верные координаты.");
    }
}
Console.WriteLine($"Точка А имеет координаты: {x1}, {y1}, {z1}");
Console.WriteLine($"Точка B имеет координаты: {x2}, {y2}, {z2}");

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между точкой A и B = {result}");
