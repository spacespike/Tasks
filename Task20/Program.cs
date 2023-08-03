// 20 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double DistanseTwoPoints (int x1, int y1, int x2, int y2){
    int cat1 = x1 - x2;
    int cat2 = y1 - y2;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return result;
}


Console.WriteLine("First point coordinats");
Console.Write("X: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second point coordinats");
Console.Write("X: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(DistanseTwoPoints(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate), 2, MidpointRounding.ToZero);
Console.WriteLine(result);