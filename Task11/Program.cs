// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Your random number is {number}");


// int firstDigit = number / 100;
// int secondDigit = number % 10;
// int result = 10 * firstDigit + secondDigit;
// Console.WriteLine(result);

int result =  DeleteSecondDigit(number);
Console.WriteLine($"Ваше число: {result}");

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return 10 * firstDigit + secondDigit;
    
}