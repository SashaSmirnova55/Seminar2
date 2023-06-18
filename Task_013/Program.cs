// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 || number < -100)
{
    while (number > 1000 || number < -1000)
    {
        number = number / 10;
    }
    number = number % 10;
    if (number < 0)
    {
        number = number * -1;
        System.Console.WriteLine("Третья цифра:" + number);
    }
    else 
    {
        Console.WriteLine("Третья цифра:" + number);
    }   
}
else
{
    System.Console.WriteLine("В этом' числе нет третьей цифры");
} 