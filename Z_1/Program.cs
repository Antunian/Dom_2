/*Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.*/

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
double c = Math.Pow((a), b);

Console.Write($"Число A в натуральной степени B равно {c}");
