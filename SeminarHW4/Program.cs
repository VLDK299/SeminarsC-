// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void Pow (int a, int b)
// {
// int result = a;

// for (int i = 1; i < b; i++)
// {
// result *= a;
// }
// Console.WriteLine($"{a} в степени {b} равно {result}");
// }

// Console.Write("введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите степень: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b <= 0) Console.WriteLine("Введите натуральное число");
// else Pow(a,b);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void Sum(int num)
// {
//     int sum = 0;
//     while (num > 0)
// {
// int i = num % 10;
// num = num / 10;
// sum = sum + i;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Sum(num);


// Напишите программу, которая задаёт массив из произвольных элементов и выводит их на экран.

int[] CreateRandomArray()
{
    int[] array = new int[20];
    for(int i = 0; i<20; i++)
    {
        array[i] = new Random().Next();
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

int[] array = CreateRandomArray();
ShowArray(array);
