// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Программа по нахождению координат двух точек в 3D пространстве");

Console.Write("Введите x1 -> ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1 -> ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1 -> ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2 -> ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2 -> ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2 ->");
int z2 = Convert.ToInt32(Console.ReadLine());


double x = Math.Pow(x2 - x1, 2);
double y = Math.Pow(y2 - y1, 2);
double z = Math.Pow(z2 - z1, 2);

double ab = Math.Round(Math.Sqrt(x + y + z), 2);

Console.WriteLine($"Растояние между точка А{x1}{y1}{z1} и B{x2}{y2}{z2} равно {ab}");
