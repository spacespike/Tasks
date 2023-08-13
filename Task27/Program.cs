// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Sum(number);
Console.WriteLine($"Sum of numbers is: {result}");

int Sum(int num)
{
    int sum = 0;
    num = Math.Abs(num);
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
