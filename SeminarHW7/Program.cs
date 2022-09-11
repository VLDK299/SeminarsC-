// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int[,] CreateRandom2dArray(int m, int n)
// {
//     int[,] array = new int [m, n];
//     for (int i=0; i<m; i++)
//     {
//         for (int j=0; j<n; j++)
//         {
//             array[i,j] = new Random().Next(1, 1000);
//         }
//     }
//     return array;
// }

// void Show2dArray (int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j =0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(m,n);
// Show2dArray(array);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Console.WriteLine("введите номер строки");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int col = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [10,10];
// RandomArray(array);

// void RandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(1, 100)/10;
//             }   
//         }
// }

// if (row > array.GetLength(0) || col > array.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {row} строки и {col} столбца равно {array[row-1,col-1]}");
// }


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,cols,min,max);

int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int [rows, cols];
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<cols; j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j =0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    }
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}

Console.WriteLine();
Show2dArray(array);

