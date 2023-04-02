// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в 
// каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[rows, columns];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

double[] avgcolumns = new double[columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        avgcolumns[i] += Convert.ToDouble(matrix[i, j]);
        
    }
  
    Console.WriteLine($" Сума чисел столбца {i}: {Math.Round(avgcolumns[i], 2)}");
}

for (int i = 0; i < avgcolumns.Length; i++)
{
    avgcolumns[i] = avgcolumns[i] / columns;
    Console.WriteLine($" Среднее арифметическое столбца {i}: {Math.Round(avgcolumns[i], 2)}");
}





