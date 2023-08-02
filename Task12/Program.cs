// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Write the fist number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = IsDivisible(number1, number2);
Console.WriteLine($"The remainder is {result}");

int IsDivisible(int num1, int num2)
{
    int remainder = num1 % num2;
    if (remainder == 0)
    {
        Console.WriteLine($"{num1} is divisible by {num2}");
        return remainder;
    }
    else
    {
        Console.WriteLine($"{num1} is not divisible by {num2}");
        return remainder;
    }
}