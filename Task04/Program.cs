// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number1 >= number2 && number1 >= number3) // Checking number 1
{
    max = number1;
}

if (number2 >= number1 && number2 >= number3) // Checking number 2
{
    max = number2;
}

if (number3 >= number1 && number3 >= number2) // Checking number 3
{
    max = number3;
}

Console.WriteLine($"Max is {max}");


// using if else
// if (number1 > number2 && number1 > number3)
// {
//     Console.Write("Number 1 is bigger than number 2 and 3: ");
//     Console.Write($"Max is {number1}");
// }
// else if (number2 > number1 && number2 > number3)
// {
//     Console.Write("Number 2 is bigger than number 1 and 3: ");
//     Console.Write($"Max is {number2}");
// }
// else if (number3 > number1 && number3 > number2)
// {
//     Console.Write("Number 3 is bigger than number 1 and 2: ");
//     Console.Write($"Max is {number3}");
// }
// else if (number1 == number2 && number2 == number3)
// {
//     Console.Write("Numbers are on par: ");
//     Console.Write($"{number1} = {number2} = {number3}");
// }
// else
// {
//     Console.Write("Two numbers are on par, please choose another numbers"); 
// }