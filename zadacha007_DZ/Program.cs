/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N:");
// bool needNumber = true;
int N = 0;
while (true)
{
    string numberFromConsole = Console.ReadLine();
    if(int.TryParse(numberFromConsole, out int newNumber))
    {
        if (newNumber >= 1)
        {
            N = newNumber;
            break;
        }
        else Console.WriteLine("Ошибка! Число должно быть больше 0:");
        // needNumber = false;
    }
    else Console.WriteLine("Ошибка! Вы ввели не число. Введите число:");
}
double result = 1;
Console.Write($"{N} -> ");
for (int i = 1; i <= N; i++)
{
    result = Math.Pow(i, 3);
    Console.Write($"{result} ");
}