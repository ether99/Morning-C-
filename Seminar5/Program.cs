// Seminar5 Lecture.
// Вид 1:
// void Method1()
// {
//   Console.WriteLine("Автор ...");
// }

// Method1();

// Вид 2:
// void Method2 (string msg)
// {
//   Console.WriteLine(msg);
// }
//   Method2("Текст сообщения");

//  void Method21(string msg, int count)
//  {
//     int i = 0; 
//     while (i < count)
//     {
//       Console.WriteLine(msg);
//       i++;
//     }
//  }
//   //Method21(msg: "Text", count: 4);
//     Method21( count: 4 , msg: "new Text" );

  // Вид 3: 
    // int Method3()
    // {
    //   return DateTime.Now.Day;

    // }
    //   int year = Method3();
    //   Console.WriteLine(year);

    // Вид 4:

      // string Method4( int count, string text )
      // {
      //    int i = 0;
      //    string result = String.Empty;
      //    while(i < count)
      //    {
      //     result = result + text;
      //     i++;
      //    }
      //    return result;
      // }

      //  string Method4(int count, string text)
      // {
      //    string result = String.Empty;
      //    {
      //    for(int i = 0; i < count; i++)
      //     result += text;
      // }
      //    return result;
      // }

      // string res = Method4(12, "Z");
      // Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//   for (int j = 2; j <= 10; j++)
//   {
//     Console.WriteLine($"{i} * {j} = {i * j}");
//   }
//   Console.WriteLine();
// }

// Работа с текстом:
/*
string text = " - Я думаю, - сказал князь, улыбаясь, - что, "
              + "ежели бы вас послали вместо нашего милого Винценгероде, "
              + "вы бы взяли приступом согласие прусского короля."
              + "Вы так красноречивы. Вы дадите мне чаю?";
  string Replace(string text, char oldValue, char newValue)
  {
      string result = string.Empty;
      int length = text.Length;
      for(int i = 0; i < length; i++ )
      {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
      }
    return result;

  }
    string newText = Replace(text, ' ', '|');
    Console.WriteLine(newText);
    Console.WriteLine();

   newText = Replace(text, 'к', 'К');
    Console.WriteLine(newText);
    Console.ReadLine();

     newText = Replace(text, 'с', 'С');
     Console.WriteLine(newText);
     Console.ReadLine();
     */

     // Упорядочить массив.

//      int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

//      void PrintArray(int[] array)
//      {
//       int count = array.Length;

//       for (int i = 0; i < array.Length; i++)
//       {  Console.Write($"{array[i]} ");
//       }
//       Console.WriteLine();
//      }
//      void SelectionSort(int[] array);
// {
//          //int minPosition = i;
       
//         for (int j = i + 1; j < array.Length - 1; j++)
//         {
//           if(array [j] < array[minPosition]) minPosition = j;

//         }
//           int temporary = array[i];
//           array[i] = array[minPosition];
//           array[minPosition] = temporary;
//         }

//       }
//         PrintArray(arr);
//         SelectionSort(arr);

//         PrintArray(arr);


 //    Seminar 5:
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[ size];
    for (int i = 0; i < size; i++)
    array[i] = new Random () . Next (minValue, maxValue + 1) ;
      return array;
}

  void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

  int GetNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)

    if (array[i] < 0)
       sum += array[i];

    return sum;
}

Console.Write("Input a quantity of elements: ");
int size = Convert. ToInt32(Console. ReadLine ( ));
Console.Write("Input a min possible value: ");
int min = Convert. ToInt32(Console. ReadLine ( ));
Console.Write("Input a max possible value: ");
int max = Convert. ToInt32(Console. ReadLine ()) ;

int[] newArray = CreateRandomArray (size, min, max);
ShowArray (newArray);

int result = GetNegativeSum (newArray);
Console.WriteLine("Sum of negatives is " + result);
*/
    // Task 1:
// . Напишите программу замены элементов массива: положительные на отрицательные и наоборот.

// Task 2:
// Задайте массив. Напишите программу, которая определяет, присутствует ли данное число в массиве.

// Task 3:
    // Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения
    // которых лежат в отрезке [a,b].