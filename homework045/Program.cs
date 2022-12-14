/*
Задача 45: Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.
*/

// метод инициализации массива
int[] InitArray(int length)
{
   int[] array = new int[length];
   Random rnd = new Random();
   for (int i = 0; i < length; i++)
   {
      array[i] = rnd.Next(0, 10);
   }
   return array;
}

// метод печати массива на экран
void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

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


int length = GetNumberFromConsole("Введите длину массива");
int[] array = InitArray(length);
int[] arrayCopy = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
   arrayCopy[i] = array[i];
}

PrintArray(array);
PrintArray(arrayCopy);
