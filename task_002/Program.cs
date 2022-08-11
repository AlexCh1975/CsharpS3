/*
    Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 2D пространстве.
    A (3,6); B (2,1) -> 5,09 
    A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

Console.Write("Введите х Тоски A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y Тоски A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите х Тоски B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y Тоски B: ");
int yb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya)); 
result = Math.Round(result, 2);
Console.WriteLine(result);



