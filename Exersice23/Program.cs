// Напишите программу,которая принимает на вход число (N) и выдает таблицу кубов от 1 до N
Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write($"{N} -> ");
while (count < N)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}
Console.Write($"{Math.Pow(count, 3)}.");
