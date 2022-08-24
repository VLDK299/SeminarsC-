// Напишите программу, которая на входе принимает одно число (N), а на выходе показывает все челые числа в промежутке от -N До N.

int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current++;
}