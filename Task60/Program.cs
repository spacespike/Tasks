// Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] Create3DArrayRndInt(int rows, int colums, int depth)
{
    int[,,] array3d = new int[rows, colums, depth];
    int temp = 9;
    for (int i = 0; i < array3d.GetLength(0); i++) // rows
    {
        for (int j = 0; j < array3d.GetLength(1); j++) // colums
        {
            for (int k = 0; k < array3d.GetLength(2); k++) // depth
            {
                array3d[i, j, k] = temp + 1;
                temp++;
            }
        }
    }

    return array3d;
}

void PrintArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k],6} ({i},{j},{k})");
            }
        }
        Console.WriteLine("  |");
    }

}


Console.Write("Enter amount of rows for the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of colums for the array: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of depth for the array: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] userArray = Create3DArrayRndInt(rows, colums, depth);
Console.WriteLine("Custom created 3d array: ");
PrintArray(userArray);
