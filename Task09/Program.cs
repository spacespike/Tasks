// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); //10 is included, 100 is not
Console.WriteLine($"Random number from [10,99]is {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"The hights is the first digit: {firstDigit}");
}
else if (firstDigit < secondDigit)
{
    Console.WriteLine($"The hights is the second digit: {secondDigit}");
}
else
{
    Console.WriteLine($"They are even {firstDigit}");
}