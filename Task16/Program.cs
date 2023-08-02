// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Write the fist number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(number1, number2);
Console.WriteLine(result ? "Yes" : "No");

bool IsSquare(int num1, int num2)
{
    return (num1 == num2 * num2 || num2 == num1 * num1);
}
