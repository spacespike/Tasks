// 18. Напишите программу, которая номер четверти плоскости, принимает на вход
//и выдаёт координаты точки (X и Y)
// в которой может находится эта
// точка.

string Quarter(int quarter)
{
    if (quarter == 1) return "x > 0 && y > 0";
    if (quarter == 2) return "x < 0 && y > 0";
    if (quarter == 3) return "x < 0 && y < 0";
    if (quarter == 4) return "x > 0 && y < 0";
    return "imposssible quarter";
}


Console.Write("Write the quarter of the dot: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = Quarter(number);
// string result = quarter > 0
//                 ? $"Coordinats belong to {quarter} quarter"
//                 : "Incorrect coordinats";

Console.WriteLine(result);