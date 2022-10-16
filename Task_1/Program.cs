// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine ("Введите число A");
int A = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Введите число B");
int B = int.Parse (Console.ReadLine()!);
Console.Write($"{Degree (A,B)} является результатом возведения числа {A} в натуральную степеть числа {B}");

double Degree (int x, int y)
{
    double result = Math.Pow(x,y);
    return result;
}