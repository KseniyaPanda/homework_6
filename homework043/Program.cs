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

// проверка что введено число
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


int b1 = GetNumberFromConsole("введите b1");
int k1 = GetNumberFromConsole("введите k1");
int b2 = GetNumberFromConsole("введите b2");
int k2 = GetNumberFromConsole("введите k2");

int x = ((b2 - b1) / (k1 - k2));
int y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

Console.WriteLine($"точка пересечения двух прямых ({x}; {y})");






{

   float k1, b1;

   float k2, b2;

   float x, y;


   cout << "k1,b1:";

   cin >> k1 >> b1;

   cout << "k2,b2:";

   cin >> k2 >> b2;


   if ((k1 == k2) && (b1 == b2))

      cout << "Прямые совпадают";

   else if (k1 == k2)

      cout << "Прямые параллельны";

   else

   {

      x = (b2 - b1) / (k1 - k2);

      y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

      cout << "x=" << x << "y=" << y;

   }

   return 0;

}