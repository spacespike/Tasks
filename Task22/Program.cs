// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


void SquareTable(int num)
{
    if (IsHigherThan1(num) == true)
    {
        for (int i = 1; i <= num; i++)
        {
            int square = i * i;
            Console.WriteLine($"{i,3} {square,5}");
        }
    }
    else Console.WriteLine("Incorrect data");
}

bool IsHigherThan1(int num)
{
    // if (num > 1) return true;            //Ternary operator can be a pain. Sadge
    // else return false;
    return num > 1 ? true : false;
}

Console.Write("Define the N: ");
int number = Convert.ToInt32(Console.ReadLine());


SquareTable(number);
