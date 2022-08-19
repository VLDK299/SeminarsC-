int day;
Console.Write("Введите порядковый номер дня недели: ");
day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Понедельник"); // Продолжить дни недели
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}