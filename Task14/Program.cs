// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Write the number:");
int number = Convert.ToInt32(Console.ReadLine());


bool result = IsDivisible(number);  //Oneline solution: Console.WriteLine(result ? "Да" : "Нет"); 
Console.WriteLine($"The result is {result}");

// bool IsDivisible(int num)
// {
//     int remainder1 = num % 7;
//     int remainder2 = num % 23;
//     if (remainder1 == 0 && remainder2 == 0)
//     {
//         Console.WriteLine($"{num} is divisible by 7 and 23");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine($"{num} is not divisible by 7 or 23");
//         return false;
//     }
// }

bool IsDivisible(int num)
{
    return num % 7 == 0 && num % 7 == 0;
}