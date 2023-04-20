// Задача. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
if(number >= 100 && number < 1000)
{
    Console.WriteLine("последняя цифра числа:" + number % 10);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}