// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);
Console.Write($"{Degree(A, B)} является результатом возведения числа {A} в натуральную степеть числа {B}");

int Degree(int x, int y)
{
    int sum = 1;
    for (int i = 0; i < y; i++)
    {
        sum = sum*x;
    }
    return sum;
}