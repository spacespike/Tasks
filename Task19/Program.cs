// 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsFiveDigit(int num)
{
    return num > 9999 && num < 100000 ? true : false;
}


void Palindrome(int num)
{
    if (IsFiveDigit(num) == true)
    {
        int first = num / 10000;
        int second = num / 1000 % 10;
        int fourth = num / 10 % 10;
        int fifth = num % 10;

        if (first == fifth && second == fourth)
        {
            Console.WriteLine($"{num} is a palindrome!");
        }
        else Console.WriteLine($"{num} is not a palindrome!");
        // string result = first == fifth && second == fourth   //Pathetic efforts to use ternary operator in various scenarious
        //                 ? Console.WriteLine($"{num} is a palindrome!") 
        //                 : Console.WriteLine($"{num}is not a palindrome!");

    }
    else Console.WriteLine($"{num} is not five  digit number");
}


Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);