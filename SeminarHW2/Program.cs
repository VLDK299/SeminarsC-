// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SecondNumber()
// {
//     int a = num / 10;
//     int second = a % 10;
//     return second;
// }
// int secnum = SecondNumber();
// Console.WriteLine("Второй цифрой данного числа является: " + secnum);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int num)
{
 if (num > 0 && num < 100)
 {
  Console.WriteLine("Третьей цифры нет.");
 }
 else if (num > 99 && num < 1000)
 {
  int third = num % 10;
  Console.WriteLine("Третьей цифрой данного числа является " + third);
 }
 else if (num > 999 && num < 10000)
 {
  int a = num % 100;
  int third = a / 10;
  Console.WriteLine("Третьей цифрой данного числа является " + third);
 }
 else if (num > 9999 && num < 100000)
 {
  int a = num % 1000;
  int third = a / 100;
  Console.WriteLine("Третьей цифрой данного числа является " + third);
 }
 else if (num > 99999 && num < 1000000)
 {
  int a = num % 10000;
  int third = a / 1000;
  Console.WriteLine("Третьей цифрой данного числа является " + third);
 }
 else if (num > 999999 && num < 10000000)
 {
  int a = num % 100000;
  int third = a / 10000;
  Console.WriteLine("Третьей цифрой данного числа является " + third);
 }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdNumber(num);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите номер дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());

// void DayOff()
// {
//     if(num == 6 || num == 7)
//     {
//         Console.WriteLine("День под данным номером является выходным.");
//     }
//     else if(num > 0 && num < 6)
//     {
//         Console.WriteLine("День под данным номером не является выходным.");
//     }
//     else
//     {
//         Console.WriteLine("Необходимо ввести число от 1 до 7!");
//     }
// }

// DayOff();