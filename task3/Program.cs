﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру от 1 до 7");
int a = int.Parse(Console.ReadLine());
    if( a == 6 || a == 7)
    {
        Console.WriteLine("yes");
    }
    else if( a > 7)
    {
        Console.WriteLine("error");
    }
    else if(a < 6)
    {
        Console.WriteLine("no");
    }
