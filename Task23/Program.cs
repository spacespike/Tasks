// Задача 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void CubeTable(int num)
{
    if (IsHigherThan1(num) == true)
    {
        for (int i = 1; i <= num; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i,3} {cube,7}");
        }
    }
    else Console.WriteLine("Incorrect data");
}

bool IsHigherThan1(int num)
{
    return num >= 1 ? true : false;
}

Console.Write("Define the N: ");
int number = Convert.ToInt32(Console.ReadLine());


CubeTable(number);
