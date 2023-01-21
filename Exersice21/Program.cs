// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.Clear();
Console.Write("Enter X1-coordinate point A: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter Y1-coordinate point A: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter Z1-coordinate point A: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Enter X2-coordinate point B: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Enter Y2-coordinate point B: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Enter Z2-coordinate point B: ");
int z2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1-z2), 2));
Console.Write($"Расстояие между заданными точками равно {Math.Round(result, 2)}");