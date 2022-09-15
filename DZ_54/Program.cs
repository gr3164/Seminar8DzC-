// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 4;
int columns = 4;
int[,] matr = new int[rows, columns];
int[] temp = new int[rows];


FillArray(matr);
Console.WriteLine("Первоначальный массив:");
PrintArray(matr);
Console.WriteLine();
Console.WriteLine();
sortRow(temp,matr);
Console.WriteLine("Новый масив:");
PrintArray(matr);

void FillArray(int[,] arr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i, j] = new Random().Next(0, 10);
            // Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

void sortRow(int[] temp, int[,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            temp[i] = matr[k, i];
        }
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            shellSort(temp);
            matr[k, i] = temp[matr.GetLength(0)-i-1];
        }
    }
}

void shellSort(int[] temp)
{
    int temp2 = temp.Length / 2;
    while (temp2 > 0)
    {
        int i, j;
        for (i = temp2; i < temp.Length; i++)
        {
            int value = temp[i];
            for (j = i - temp2; (j >= 0) && (temp[j] > value); j -= temp2)
                temp[j + temp2] = temp[j];
            temp[j + temp2] = value;
        }
        temp2 /= 2;
    }
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

