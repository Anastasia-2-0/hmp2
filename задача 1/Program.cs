// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int num2 = 0;
if(num > 99 || num < 1000)
{
    num2 = num / 10;
    num2 = num2 % 10;
}
else
{
    Console.WriteLine("error");
}
Console.WriteLine($"Вторая цифра числа {num} равна {num2}");
