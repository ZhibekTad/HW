﻿// Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Input first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0; 

if(number1 > max)
{
    max = number1;
}
if(number2 > max)
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}
Console.WriteLine("max = " + max);