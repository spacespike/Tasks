// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    Console.Write("Number 2 is bigger than number 1: ");
    Console.Write($"{number2} > {number1}, so max is {number2}");
}
else if (number1 > number2)
{
    Console.Write("Number 1 is bigger than number 2: ");
    Console.Write($"{number1} > {number2}, so max is {number1}");
}
else if (number1 == number2)
{
    Console.Write("Number 1 is on par with number 2: ");
    Console.Write($"{number1} = {number2}");
}