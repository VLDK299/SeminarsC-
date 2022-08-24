//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int num1, num2; // Задаем две переменных

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine()); // Считываем первое число

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine()); // Считываем второе число

if (num1 > num2) // Сравниваем два числа
{
    Console.WriteLine("Первое число больше второго.");
}
else if (num2 > num1)
{
    Console.WriteLine("Второе число больше первого.");
}
*/


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
int num1, num2, num3;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1; //Перебираем числа и находим максимальное
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.WriteLine("Максимальным является число " + max);
*/


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2==1) // Проверяем число на четность
            {
                Console.WriteLine("число нечетное");
           
            }
            else
            {
                Console.WriteLine("Число четное");
            }
*/


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
int N;

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= N)
{
    Console.Write(current + " ");
    current++;
}
*/