// Дополнительная задача:
// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

using System;
Console.Clear();

Console.WriteLine("Сколько строк треугольника Паскаля вывести?");
Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
int k = 1;

PrintRowsPaskal(n);

void PrintStringPaskal(int k, int i)
{
    for (k = 0; k <= i; k++)
    {
        Console.Write("\t" + factorial(i) / (factorial(k) * factorial(i - k)) + "\t"); 
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(); 
}

void PrintWhitespace(int k, int i)
{
    for (k = 0; k <= (n - i); k++) 
    {
        Console.Write("\t");
    }
}

void PrintRowsPaskal(double n)
{
    for (int i = 0; i < n; i++)
    {
        PrintWhitespace(k, i);
        PrintStringPaskal(k, i);
    }
}

double factorial(double n)
{
    double i = 1;
    double x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
