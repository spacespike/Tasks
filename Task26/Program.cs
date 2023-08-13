//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//12 -> 2


Console.WriteLine("Enter natural number");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountNumbersDigits(number);
Console.WriteLine($"Number of digits {number} = {result}");

int CountNumbersDigits(int num)
{
    int countDigits = 0;
    while (num != 0)
    {
        countDigits++;
        num = num / 10;
    }
    return countDigits;
}