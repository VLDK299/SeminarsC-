// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.Write($"Введите количество чисел: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];

// void InputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введите {i+1}-e число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }


// int Comparison(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if(array[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// InputNumbers(m);
// Console.WriteLine($"Чисел больше 0: {Comparison(array)}");


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


double[,] coeff = new double[2, 2];
double[] point = new double[2];

void InputCoeff(){
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Answer(double[,] coeff)
{
  point[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  point[1] = point[0] * coeff[0,0] + coeff[0,1];
  return point;
}

void Result(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Answer(coeff);
    Console.Write($"\nТочка пересечения прямых: ({point[0]}, {point[1]})");
  }
}

InputCoeff();
Result(coeff);