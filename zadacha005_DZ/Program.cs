/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите пятизначное число число:");

// проверка на дурака и проверка на то что число пятизначное

bool needNumber = true;
int number = 0;

while (needNumber)
{
    string numberFromConsole = Console.ReadLine();
    if (int.TryParse(numberFromConsole, out int newNumber))
    {
        if (newNumber >= 10000 && newNumber <= 99999)
        {
            needNumber = false;
            number = newNumber;
        }
        else Console.WriteLine("Ошибка! Введите пятизначное число:");

    }
    else
    {
        Console.WriteLine("Ошибка! Вы ввели не число. Введите пятизначное число:");
    }
}

Console.WriteLine($"Отлично! Вы ввели число {number}");

string str = number.ToString(); // перевод числа в строку

if (str[0] == str[4] && str[1] == str[3]) Console.WriteLine($"Это число является палиндромом!");
else Console.WriteLine($"Это число НЕ является палиндромом!");