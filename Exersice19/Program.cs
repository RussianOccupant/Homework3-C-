// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int a1 = num % 10;
int a2 = (num / 10) % 10;
int a4 = (num / 1000) % 10;
int a5 = num / 10000;

if (a5 == a1 && a2 == a4)
{
    Console.WriteLine("Данное число является палиндромом!");
}
else 
{
    Console.WriteLine("Данное число не является палиндромом!");
}