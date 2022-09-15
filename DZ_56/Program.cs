// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;
int columns = 3;
int[,] matr = new int[rows, columns];

FillArray(matr);
PrintArray(matr);
Console.WriteLine();
minSumNumber(matr);



void minSumNumber(int[,] matr)
{
    int[] temp = new int[rows];
    int min = int.MaxValue;
    int index = -1;

    for (int i = 0; i < rows; i++)
    {
        int sumNumbers = 0;

        for (int j = 0; j < columns; j++)
        {
            sumNumbers += matr[i, j];
            temp[i] = Convert.ToInt32(sumNumbers);
        }

        if (min > temp[i])
        {
            min = temp[i];
            index = i + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма строки: {min},     Строка: {index}" );
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

