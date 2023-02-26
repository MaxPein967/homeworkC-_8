// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int n = ReadInt("Введите количество строк: ");
int m = ReadInt("Введите количество столбцов: ");

int[,] nums = new int[n, m];
Console.WriteLine();
FillArrayRandomNumbers(nums);
PrintArray(nums);
SortToLower(nums);
Console.WriteLine();
PrintArray(nums);


int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(10, 100));
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            for (int k = 0; k < nums.GetLength(1) - 1; k++)
            {
                if (nums[i, k] < nums[i, k + 1])
                {
                    int temp = nums[i, k + 1];
                    nums[i, k + 1] = nums[i, k];
                    nums[i, k] = temp;
                }
            }
        }
    }
}