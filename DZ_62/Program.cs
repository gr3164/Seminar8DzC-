// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] matr = new int[n, n];

FillArray(matr);
PrintArray(matr);

void FillArray(int[,] arr)
{
    int count = 1;
    for (int i = 0; i < n - 2; i++)
    {
        for (int j = i; j < n - i; j++) matr[i, j] = count++;
        for (int k = i + 1; k < n - i; k++) matr[k, n - 1 - i] = count++;
        for (int j = n - i - 2; j >= i; j--) matr[n - 1 - i, j] = count++;
        for (int k = n - 2 - i; k > i; k--) matr[k, i] = count++;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}