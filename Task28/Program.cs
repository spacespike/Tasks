// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Enter number N: ");
int number = Convert.ToInt32(Console.ReadLine()); // int number = int.Parse(Console.ReadLine()!); // 

int result = FactorialN(number);

Console.WriteLine($"Factorial of {number} is: {result}");

int FactorialN(int num)
{
    int factorial = 1;
    while (num != 0)
    {
        checked
        {
            factorial *= num;
            num--;
        }
    }
    return factorial;
}