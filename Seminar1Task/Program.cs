int num1, num2; // Задаем переменные.

Console.Write("Введите первое число: "); 

num1 = Convert.ToInt32(Console.ReadLine()); // Вводим первое число.

Console.Write("Введите второе число: ");

num2 = Convert.ToInt32(Console.ReadLine()); // Вводим второе число.

if (num1 == num2 * num2) // Задаем условие, чтобы проверить, является ли первое число квадратом второго.
{
    Console.WriteLine("Первое число равно квадрату второго");
}
else
{
    Console.WriteLine("Первое число не равно квадрату второго");
}

