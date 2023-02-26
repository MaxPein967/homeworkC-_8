// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int n = ReadInt("Введите количество строк: ");
int m = ReadInt("Введите количество столбцов: ");
int[,] nums = new int[n, m];
int[,] secondNums = new int[n, m];
int[,] resultNums = new int[n, m];

Console.WriteLine();
FillArrayRandomNumbers(nums);
PrintArray(nums);

Console.WriteLine();
FillArrayRandomNumbers(secondNums);
PrintArray(secondNums);

if (nums.GetLength(0) != secondNums.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < secondNums.GetLength(1); j++)
    {
        resultNums[i, j] = 0;
        for (int k = 0; k < nums.GetLength(1); k++)
        {
            resultNums[i, j] += nums[i, k] * secondNums[k, j];
        }
    }
}

PrintArray(resultNums);

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
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
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
