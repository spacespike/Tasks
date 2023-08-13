﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Enter natural number:");
int number = Convert.ToInt32(Console.ReadLine()!);

int sum = SumOFNumbers(number);
Console.WriteLine($"Sum of numbers from 1 to {number} = {sum}");

int SumOFNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i; // sum = sum + i
        }
    }
    return sum;
}