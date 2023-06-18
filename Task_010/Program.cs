// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = 0;
Console.WriteLine("Введите трехзначное число");

number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    number = number / 10;
    number = number % 10;
}
else 
{
    System.Console.WriteLine("Вы ввели некорректное число. Попробуйте ещё раз: ");
}

Console.WriteLine("Вторая цифра: " + number);