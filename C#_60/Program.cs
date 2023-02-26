// Задача 60.Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] nums = new int[2, 2, 2];
FillArray(nums);
PrintIndex(nums);

void PrintIndex(int[,,] array)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < nums.GetLength(2); k++)
            {
                Console.Write($"{nums[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] array)
{
    int[] temp = new int[nums.GetLength(0) * nums.GetLength(1) * nums.GetLength(2)];
    int number;
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
    int count = 0;
    for (int x = 0; x < nums.GetLength(0); x++)
    {
        for (int y = 0; y < nums.GetLength(1); y++)
        {
            for (int z = 0; z < nums.GetLength(2); z++)
            {
                nums[x, y, z] = temp[count];
                count++;
            }
        }
    }
}



