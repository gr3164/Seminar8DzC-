// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int n = 2;

int[,] matr1 = new int[,] { { 2,4 }, { 3,2 } };
int[,] matr2 = new int[,] { { 3,4 }, { 3,3 } };
int[,] matr3 = new int[,] { { 2,4 }, { 3,3 } };

for (int i = 0; i < matr3.GetLength(0); i++)
{
    for (int j = 0; j < matr3.GetLength(1); j++)
    {
        int sumNumbers = 0;
        for (int k = 0; k < matr1.GetLength(1); k++)
        {
            sumNumbers += matr1[i, k] * matr2[k, j];
        }
        matr3[i, j] = sumNumbers;
    }
}

PrintArray(matr1);
Console.WriteLine();
PrintArray(matr2);
Console.WriteLine();
PrintArray(matr3);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}




























// int[] matrix = new int[n];
// int[] matr = new int[n];

// FillArray(matrix);
// FillArray(matr);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine();
// PrintArray(matr);

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 10);
//     }
// }

// void PrintArray(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + "\t");
// }
//     Console.Write(String.Join(", ", arr));
//     Console.WriteLine();
// }

// int[,] Multiply = new int[Matrix3x2, Matrix3x2];
// System.Numerics.Matrix3x2 Multiply(System.Numerics.Matrix3x2 matr, System.Numerics.Matrix3x2 matrix);