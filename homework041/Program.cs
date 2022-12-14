/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 3
*/

/*
Console.WriteLine("Введите все числа через пробел");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] > 0)
   {
      count++;
   }
}

Console.WriteLine($"чисел больше 0: {count}");
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

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

int length = GetNumberFromConsole("Введите длину массива");
int[] array = new int[length];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
   array[i] = GetNumberFromConsole($"Введите {i + 1} число");
   if (array[i] > 0)
   {
      count++;
   }
}

PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 = {count}");
