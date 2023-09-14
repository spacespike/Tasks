// Задайте значение N. 
// Напишите программу, 
// которая выведет все 
// натуральные числа 
// в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int count = 1;
void NumberToOne(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NumberToOne(n, count + 1);
        if (count == 1)
        {
            Console.WriteLine(count);
        }
        else { Console.Write(count + ", "); }
    }
}


Console.Write("Enter number N: ");
int number = Convert.ToInt32(Console.ReadLine());
NumberToOne(number, count);