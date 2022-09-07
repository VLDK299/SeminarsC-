// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray()
// {
//     int[] array = new int[20];
//     for(int i = 0; i<20; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int CountNum(int[] array)
// {
//     int count = 0;
//     for (int j = 0; j < array.Length; j++)
//     {
// if (array[j] % 2 == 0)
// count++;
//     }
//     return count;
// }


// int[] array = CreateRandomArray();
// ShowArray(array);
// Console.WriteLine();
// int count = CountNum(array);
// Console.WriteLine($"В данном массиве {count} четных чисел");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray()
// {
//     int[] array = new int[20];
//     for(int i = 0; i<20; i++)
//     {
//         array[i] = new Random().Next(1, 10000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int SumNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i<array.Length; i++)
//     {
//         if(array[i]%2!=0) count+=array[i];
//     }
//     return count;
// }

// int[] array = CreateRandomArray();
// ShowArray(array);
// Console.WriteLine();
// int sum = SumNumbers(array);
// Console.WriteLine($"Сумма нечетных чисел равна {sum}");


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

int[] CreateRandomArray()
{
    int[] array = new int[20];
    for(int i = 0; i<20; i++)
    {
        array[i] = new Random().Next(1, 10000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindMaxValue(int[] array)
{
    int max = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>max) max = array[i];
    }
    return max;
}

int FindMinValue(int[] array)
{
    int max = FindMaxValue(array);
    int min = max;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<min) min = array[i];
    }
    return min;
}

int[] array = CreateRandomArray();
ShowArray(array);
Console.WriteLine();
int max = FindMaxValue(array);
int min = FindMinValue(array);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {max-min}");