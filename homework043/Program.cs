/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
y = k1 * x + b1      y = k2 * x + b2
x = (b2 - b1) / (k1 - k2)
y = (k1 * (b2 - b1)) / (k1 - k2) + b1
*/


int GetNumberFromConsole(string message)
{
   bool isCorrect = false;
   int result = 0;
   while (!isCorrect)
   {
      Console.WriteLine(message);

      if (int.TryParse(Console.ReadLine(), out result))
      {
         isCorrect = true;
      }
      else
      {
         Console.WriteLine("Введено не число. Введите число");
      }
   }
   return result;
}

double b1 = GetNumberFromConsole("введите b1");
double k1 = GetNumberFromConsole("введите k1");
double b2 = GetNumberFromConsole("введите b2");
double k2 = GetNumberFromConsole("введите k2");

if ((k1 == k2) && (b1 == b2))
{
   Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
   Console.WriteLine("Прямые параллельны, точек пересечения нет");
}
else
{
   double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
   double y = Math.Round((k1 * (b2 - b1)) / (k1 - k2) + b1, 2);
   Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");
}
