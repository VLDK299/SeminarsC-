// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите число: ");
// string num = Console.ReadLine();

// void Palindorm(string num)
// {
//   if (num[0]==num[4] || num[1]==num[3])
//   {
//     Console.WriteLine($"Число: {num} является палиндром.");
//   }
//   else Console.WriteLine($"Число: {num} не является палиндром.");
// }

// if (num!.Length == 5)
// {
//     Palindorm(num);
// }
// else Console.WriteLine($"Введите пятизначное число!");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coor, string point)
// {
//     Console.Write($"Введите координату {coor} точки {point}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Answer(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2)
// {
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2)); // Формула для нахождения расстояния между точками.
// }

// double length =  Math.Round (Answer(x1, x2, y1, y2, z1, z2), 2 ); // Округление.

// Console.WriteLine($"Расстояние между точками равно {length}");



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube) // Вычисляет кубы чисел
{
  int i = 1;
  int length = cube.Length;
  while (i <  length)
  {
    cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    i++;
  }
}

void PrintArray(int[] coll) // Выводит список кубов
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index] + " ");
    index++;
  }
} 

int[] array = new int[cube + 1];
Cube(array);
PrintArray(array);