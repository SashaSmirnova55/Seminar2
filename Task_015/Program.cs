// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day = ReadInt("Введите число от 1 до 7, например понедельник 1: ");
Console.WriteLine(DayOfTheWeek(day));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string DayOfTheWeek(int day)
{
    if (day > 0 && day < 8)
    {
        if (day == 7 || day == 6)
        {
            Console.Write("Выходной ");
        }
        else
        {
            Console.Write("Рабочий ");
        }
    }
    else
    {
        Console.Write("Неверное число");
    }
    return "день";
}