// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        // int[,] Matrix = new int[rows, columns];
        // for (int i = 0; i < Matrix.GetLength(0); i++)
        // {
        //        for (int j = 0; j < Matrix.GetLength(1); j++)
        //     {
        //         Console.Write($"{Matrix[i,j]} ");
        //     }
        //     Console.WriteLine();
        // }

void PrintArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }  
    Console.WriteLine();
    }
}

void FillArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
     {
        matr[i,j] = new Random().Next(-100,100);
        matr[i,j] = matr[i,j] / 10;
     }
    }
}

double [,] matrix = new double[rows, columns];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);