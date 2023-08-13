// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine()); // A
Console.Write("Enter number B: ");
int numberB = int.Parse(Console.ReadLine()!); // 

int result = Power(numberA, numberB);

Console.WriteLine($"The number {numberA} in power {numberB} is: {result}");

int Power(int numA, int numB)
{
    int exponentAB = 1;
    while (numB != 0)
    {
        checked
        {
            exponentAB *= numA ;
            numB--;
        }
    }
    return exponentAB;
}