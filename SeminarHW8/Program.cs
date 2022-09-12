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


// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Change2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

 void MinRow(int[,] array)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        line += array[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов: {line}. ");
}

// Заполните спирально массив 4 на 4.

int n = 4;
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

void ShowSpiral2dArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();

// int[,] array2 = Change2dArray(array);
// Show2dArray(array2);

// MinRow(array);

ShowSpiral2dArray(array);

