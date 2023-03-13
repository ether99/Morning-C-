

// Homework 4:

//     Task 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//             3, 5 -> 243 (3⁵)
//             2, 4 -> 16

   /* int numberA = ReadInt("Enter a number: ");
    int numberB = ReadInt("Enter the gegree: ");
        Degree(numberA, numberB);

        void Degree(int a, int b)
  {
    int result = 1;
        for (int i = 1; i <= b; i++)
    {
         result = result * a;
    }
    Console.WriteLine(a + " in degree " + b + " =  " + result);
  }


        int ReadInt(string message)
  {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
  }

*/
    



// Task 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//         452 -> 11
//         82 -> 10
//         9012 -> 12
/*
    int number = ReadInt("Enter a number: ");

    int len = NumberLen(number);
    SumNumbers(number, len);
    int NumberLen(int a)
    {
        int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

    void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"sum of digits {sum}");
}

    int ReadInt(string message)
{
     Console.Write(message);
       return Convert.ToInt32(Console.ReadLine());
}
*/

// Task 3: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//         1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//         6, 1, 33 -> [6, 1, 33]

/*
   int lenArray = ReadInt("Enter the length of the array: ");

    int[] randomArray = new int[lenArray];
      for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
