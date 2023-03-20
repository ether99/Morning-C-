
  // Homework 5:
//   Task 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//           которая покажет количество чётных чисел в массиве.
//           [345, 897, 568, 234] -> 2

  /*
  Console.WriteLine("Enter the size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    int count = 0;

    ArrayRandomNumbers(numbers);
    PrintArray(numbers);
      for (int i = 0; i < numbers.Length; i++)
      {
          if (numbers[i] % 2 == 0)
          count++;
      }
    Console.WriteLine($"The number of even numbers in the array: {count} ");

    void ArrayRandomNumbers(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(99,999);
        }
    }
    void PrintArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
*/

// Task 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//         стоящих на нечётных позициях.
//         [3, 7, 23, 12] -> 19
//         [-4, -6, 89, 6] -> 0

/*
    int size = ReadInt("Enter the size of the array: ");
    int min = ReadInt("Enter the minimum of the array: ");
    int max = ReadInt("Enter the maximum of the array: ");
     int [] numbers = new int[size];

     ArrayRandomNumbers(numbers);
     PrintArray(numbers);
    int result = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        
            result += numbers[i];
    }
      Console.WriteLine($"The sum of the elements standing in odd positions - {result}");

void ArrayRandomNumbers(int [] array) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

    int ReadInt(string message)  
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());

    }

*/

// Task 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//         минимальным элементом массива.
//         [3 7 22 2 78] -> 76
/*
    int size = 9;
    int[] numbers = new int[size];
    ArrayRandomNumbers(numbers);
    PrintArray(numbers);

      int max = numbers[0];
      int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
    Console.WriteLine($"Minimum number: {min}");
    Console.WriteLine($"Maximum number: {max}");
    Console.WriteLine($"The difference between the maximum and minimum numbers: {max-min}");

      void ArrayRandomNumbers(int[] array)
      {
          for (int i = 0; i < array.Length; i++)
          {
              array[i] = new Random().Next(1, 555);
          }
      }
      void PrintArray(int[] array)
      {
          for (int i = 0; i < array.Length; i++)
          {
              Console.Write(array[i] + " ");
          }
          Console.WriteLine();
      }
      */