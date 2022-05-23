/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

//  Функция которая проверяет входящее значение (должно быть 1,2,3 или 4)

int GetQuarter()
{
    while (true)
    {
        int quater = Convert.ToInt32(Console.ReadLine());
        if (quater != 1 quater != 2 quater != 3 quater != 4)
        {
            Console.WriteLine("Введите число 1,2,3 или 4");
        }
        else
        {
            return quater;
        }
    }
}


void GetRange(int quater) // функция которая 
{
    if (quater == 1)
    {
        Console.WriteLine("Диапазон X > 0, Y > 0");
    }
    else if (quater == 2)
    {
        Console.WriteLine("Диапазон X < 0, Y > 0");
    }
    else if (quater == 3)
    {
        Console.WriteLine("Диапазон X < 0, Y < 0");
    }
    else
    {
        Console.WriteLine("Диапазон X > 0, Y < 0");
    }
}

int a = GetQuarter();
GetRange(a);
