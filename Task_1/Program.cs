// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



int[,] FillMatrix(int r, int c)
{
    int[,] arr = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}

int[,] SwapArrayFirstWithEnd(int[,] arr1)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        int t = arr1[arr1.GetLength(0) - 1, j];
        arr1[arr1.GetLength(0) - 1, j] = arr1[0, j];
        arr1[0, j] = t;
    }
    return arr1;
}


System.Console.Write("Ведите m - ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите n - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mas = FillMatrix(m, n);
SwapArrayFirstWithEnd(mas);

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write($" {mas[i, j]} ");
    }
    Console.WriteLine();
}
