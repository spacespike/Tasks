// Задача 66: Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumFromMToN(int firstNumber, int secondNumber)
{
    int result = firstNumber;
    if (firstNumber == secondNumber)    //not to end up adding first number twice
        return 0;
    else if (secondNumber < firstNumber)
        return 0;
    else
    {
        firstNumber++;
        result = firstNumber + SumFromMToN(firstNumber, secondNumber);
        return result;
    }
}


Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(m + SumFromMToN(m, n));   //added first number here