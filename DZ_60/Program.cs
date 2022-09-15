// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array = new int[2, 2, 2];

FillArray(array);
PrintArr(array);

void FillArray(int[,,] arr)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number = 0;

    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];

        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }

    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[index];
                index++;
            }
        }
    }
}

void PrintArr(int[,,] arr)
{
    string index = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                index = Convert.ToString(i) + "," + Convert.ToString(j) + "," + Convert.ToString(k);
                Console.Write($"{array[i, j, k]}({index})" + "\t");
            }
            Console.WriteLine();
        }
    }
}
