int num;

// Ввод данных
Console.Write("Введите число: ");

num = Convert.ToInt32(Console.ReadLine());

// Вычисление квадрата
int sqare = num * num;

if (sqare >= 100)
{
    Console.WriteLine("Such a big sqare: " + sqare);
}
else
{
    Console.WriteLine("Квадрат данного числа равен: " + sqare);
}

